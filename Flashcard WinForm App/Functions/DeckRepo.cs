using Flashcard_WinForm_App.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Functions
{
    //fetches and updates decks in the database (NOT WHERE THE PROGRAM LOGIC GOES, JUST THE DB)
    public class DeckRepo
    {
        public List<Deck> GetDecksForUser(int userId) //returns a list of decks for a given user ID
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

        public void DecksRefreshDB(List<Deck> decks)
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Deck WHERE UserID = $uid";
                command.Parameters.AddWithValue("$uid", decks[0].UserID); //assumes all decks in the list belong to the same user
                command.ExecuteNonQuery();
                foreach (var deck in decks)
                {
                    command.CommandText = "INSERT INTO Deck (DeckID, UserID, Label, Description) VALUES ($did, $uid, $label, $desc)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("$did", deck.DeckID);
                    command.Parameters.AddWithValue("$uid", deck.UserID);
                    command.Parameters.AddWithValue("$label", deck.Label);
                    command.Parameters.AddWithValue("$desc", deck.Description);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
