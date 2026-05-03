using Flashcard_WinForm_App.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Functions
{
    //fetches and updates flashcards in the database (NOT WHERE THE PROGRAM LOGIC GOES, JUST THE DB)
    public class CardRepo
    {
        public List<Flashcard> GetFlashcardsDB(List<Deck> decks) //returns all flashcards from all available decks of the user
        {
            var flashcards = new List<Flashcard>();

            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT FlashcardID, DeckID, Question, Answer FROM Flashcard WHERE DeckID = $did";

                foreach (var deck in decks)
                {
                    command.Parameters.AddWithValue("$did", deck.DeckID);

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
            }
            return flashcards;
        }

        public void UpdateFlashcardsDB(List<Flashcard> cards) 
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                foreach (var card in cards)
                {
                    var command = connection.CreateCommand();
                    command.CommandText = "UPDATE Flashcard SET Mastered = $m WHERE CardID = $id";
                    command.Parameters.AddWithValue("$m", card.Mastered ? 1 : 0);
                    command.Parameters.AddWithValue("$id", card.CardID);
                    command.ExecuteNonQuery();
                }
            }
        }        
    }
}
