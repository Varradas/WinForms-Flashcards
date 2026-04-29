using Flashcard_WinForm_App.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Functions
{
    //handles flashcard operations for the database (NOT WHERE THE PROGRAM LOGIC GOES, JUST THE DB)
    public class CardRepo
    {
        public List<Flashcard> GetFlashcards(int deckId)
        {
            var flashcards = new List<Flashcard>();

            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT FlashcardID, DeckID, Question, Answer FROM Flashcard WHERE DeckID = $did";
                command.Parameters.AddWithValue("$did", deckId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        flashcards.Add(new Flashcard
                        {
                            CardID = reader.GetInt32(0),
                            DeckID = reader.GetInt32(1),
                            Definition = reader.GetString(2),
                            Answer = reader.GetString(3),
                            Mastered = false            
                        });
                    }
                }
            }
            return flashcards;
        }

        public void UpdateMastery(int cardId, bool mastered)
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE Flashcard SET Mastered = $m WHERE CardID = $id";
                command.Parameters.AddWithValue("$m", mastered ? 1 : 0);
                command.Parameters.AddWithValue("$id", cardId);
                command.ExecuteNonQuery();
            }
        }

        public void AddFlashcard(Flashcard card)
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Flashcard (DeckID, Question, Answer, Mastered) VALUES ($did, $q, $a, 0)";
                command.Parameters.AddWithValue("$did", card.DeckID);
                command.Parameters.AddWithValue("$q", card.Definition);
                command.Parameters.AddWithValue("$a", card.Answer);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteFlashcard(int cardId)
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Flashcard WHERE CardID = $id";
                command.Parameters.AddWithValue("$id", cardId);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateFlashcard(Flashcard card)
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE Flashcard SET Question = $q, Answer = $a WHERE CardID = $id";
                command.Parameters.AddWithValue("$q", card.Definition);
                command.Parameters.AddWithValue("$a", card.Answer);
                command.Parameters.AddWithValue("$id", card.CardID);
                command.ExecuteNonQuery();
            }
        }
    }
}
