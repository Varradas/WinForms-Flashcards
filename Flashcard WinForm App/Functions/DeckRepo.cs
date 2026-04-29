using Flashcard_WinForm_App.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Functions
{
    //handles deck operations for the database (NOT WHERE THE PROGRAM LOGIC GOES, JUST THE DB)
    public class DeckRepo
    {
        public List<Deck> GetDecksForUser(int userId)
        {
            var decks = new List<Deck>();

            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT DeckID, UserID, Label, Description FROM Deck WHERE UserID = $uid";
                command.Parameters.AddWithValue("$uid", userId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decks.Add(new Deck
                        {
                            DeckID = reader.GetInt32(0),
                            UserID = reader.GetInt32(1),
                            Label = reader.GetString(2),
                            Description = reader.GetString(3)
                        });
                    }
                }
            }
            return decks;
        }

        public void AddDeck(Deck deck)
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Deck (UserID, Label, Description) VALUES ($uid, $label, $desc)";
                command.Parameters.AddWithValue("$uid", deck.UserID);
                command.Parameters.AddWithValue("$label", deck.Label);
                command.Parameters.AddWithValue("$desc", deck.Description);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteDeck(int deckId, int userId)
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Deck WHERE DeckID = $did AND UserID = $uid";
                command.Parameters.AddWithValue("$did", deckId);
                command.Parameters.AddWithValue("$uid", userId);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateDeck(Deck deck)
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE Deck SET Label = $label, Description = $desc WHERE DeckID = $did AND UserID = $uid";
                command.Parameters.AddWithValue("$label", deck.Label);
                command.Parameters.AddWithValue("$desc", deck.Description);
                command.Parameters.AddWithValue("$did", deck.DeckID);
                command.Parameters.AddWithValue("$uid", deck.UserID);
                command.ExecuteNonQuery();
            }
        }
    }
}
