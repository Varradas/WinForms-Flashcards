using Flashcard_WinForm_App.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

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
                command.CommandText = "SELECT CardID, DeckID, Definition, Answer, Mastered FROM Flashcard WHERE DeckID = $did";

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
                                Mastered = Convert.ToBoolean(reader.GetInt32(4))
                            });
                        }
                    }
                }
            }
            return flashcards;
        }

        public void RefreshFlashcardsDB(List<Flashcard> cards, int deckID)
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Flashcard WHERE DeckID = $did";
                command.Parameters.AddWithValue("$did", cards[0].DeckID); //assumes all cards in the list belong to the same deck
                command.ExecuteNonQuery();
                foreach (var card in cards)
                {
                    command.CommandText = "INSERT INTO Flashcard (CardID, DeckID, Definition, Answer, Mastered) VALUES ($cid, $did, $def, $ans, $mast)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("$cid", card.CardID);
                    command.Parameters.AddWithValue("$did", card.DeckID);
                    command.Parameters.AddWithValue("$def", card.Definition);
                    command.Parameters.AddWithValue("$ans", card.Answer);
                    command.Parameters.AddWithValue("$mast", card.Mastered ? 1 : 0);
                    command.ExecuteNonQuery();
                }
            }
        }
        
    }
}
