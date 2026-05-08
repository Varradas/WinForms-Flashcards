using Flashcard_WinForm_App.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flashcard_WinForm_App.Data
{
    public class Manager
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Deck> Decks { get; set; } = new List<Deck>();
        public List<Flashcard> Cards { get; set; } = new List<Flashcard>();

        private readonly string _connectionString = Flashcard_WinForm_App.Data.DBPath.ConnectionString;

        public void LoadAllData()
        {
            Users.Clear(); Decks.Clear(); Cards.Clear();
            using (var conn = new SqliteConnection(_connectionString))
            {
                conn.Open();
                var userCmd = new SqliteCommand("SELECT UserID, Username, Nickname, PasswordHash, Config FROM User", conn);
                using (var r = userCmd.ExecuteReader()) while (r.Read()) Users.Add(new User { 
                        UserID = r.GetString(0), 
                        Username = r.GetString(1), 
                        Nickname = r.GetString(2), 
                        PasswordHash = r.GetString(3), 
                        Config = r.IsDBNull(4) ? null : (byte[])r["Config"] 
                });

                var deckCmd = new SqliteCommand("SELECT DeckID, UserID, Label, Description FROM Deck", conn);
                using (var r = deckCmd.ExecuteReader()) while (r.Read()) Decks.Add(new Deck {
                        DeckID = r.GetString(0), 
                        UserID = r.GetString(1), 
                        Label = r.GetString(2), 
                        Description = r.GetString(3) 
                });

                var cardCmd = new SqliteCommand("SELECT CardID, DeckID, Definition, Answer, Mastered FROM Flashcard", conn);
                using (var r = cardCmd.ExecuteReader()) while (r.Read()) Cards.Add(new Flashcard {
                        CardID = r.GetString(0), 
                        DeckID = r.GetString(1), 
                        Definition = r.GetString(2), 
                        Answer = r.GetString(3), 
                        Mastered = r.GetBoolean(4) 
                });
            }
        }

        // --- USER CRUD ---
        public void CreateUser(User u)
        {
            Users.Add(u);

            ExecuteNonQuery("INSERT INTO User (UserID, Username, Nickname, PasswordHash) VALUES (@id, @un, @nn, @ph)",
                new SqliteParameter("@id", u.UserID), 
                new SqliteParameter("@un", u.Username), 
                new SqliteParameter("@nn", u.Nickname), 
                new SqliteParameter("@ph", u.PasswordHash)
                );
        }

        public void DeleteUser(string userId)
        {
            var deckIds = Decks.Where(d => d.UserID == userId).Select(d => d.DeckID).ToList();
            foreach (var dId in deckIds) Cards.RemoveAll(c => c.DeckID == dId);
            Decks.RemoveAll(d => d.UserID == userId);
            Users.RemoveAll(u => u.UserID == userId);

            ExecuteNonQuery("DELETE FROM User WHERE UserID = @id", new SqliteParameter("@id", userId));


        }

        // --- DECK CRUD ---
        public void CreateDeck(string userId, string label, string desc)
        {
            var d = new Deck { UserID = userId, Label = label, Description = desc };
            Decks.Add(d);

            ExecuteNonQuery("INSERT INTO Deck (DeckID, UserID, Label, Description) VALUES (@id, @uid, @l, @d)",
                new SqliteParameter("@id", d.DeckID), 
                new SqliteParameter("@uid", d.UserID), 
                new SqliteParameter("@l", d.Label), 
                new SqliteParameter("@d", d.Description)
                );
        }

        public void UpdateDeck(string deckId, string label, string desc)
        {
            var d = Decks.FirstOrDefault(x => x.DeckID == deckId);
            if (d == null) return;
            d.Label = label; d.Description = desc;

            ExecuteNonQuery("UPDATE Deck SET Label = @l, Description = @d WHERE DeckID = @id", 
                new SqliteParameter("@l", label), 
                new SqliteParameter("@d", desc), 
                new SqliteParameter("@id", deckId)
                );
        }

        public void DeleteDeck(string deckId)
        {
            Cards.RemoveAll(c => c.DeckID == deckId);
            Decks.RemoveAll(d => d.DeckID == deckId);

            ExecuteNonQuery("DELETE FROM Deck WHERE DeckID = @id", new SqliteParameter("@id", deckId));
        }

        // --- FLASHCARD CRUD ---
        public void CreateCard(string deckId, string def, string ans)
        {
            var c = new Flashcard { DeckID = deckId, Definition = def, Answer = ans };
            Cards.Add(c);
            ExecuteNonQuery("INSERT INTO Flashcard (CardID, DeckID, Definition, Answer, Mastered) VALUES (@id, @did, @def, @ans, @m)",
                new SqliteParameter("@id", c.CardID), 
                new SqliteParameter("@did", c.DeckID), 
                new SqliteParameter("@def", c.Definition), 
                new SqliteParameter("@ans", c.Answer), 
                new SqliteParameter("@m", false)
                );
        }

        public void UpdateCard(string cardId, string def, string ans, bool mastered)
        {
            var c = Cards.FirstOrDefault(x => x.CardID == cardId);
            if (c == null) return;
            c.Definition = def; c.Answer = ans; c.Mastered = mastered;

            ExecuteNonQuery("UPDATE Flashcard SET Definition = @def, Answer = @ans, Mastered = @m WHERE CardID = @id",
                new SqliteParameter("@def", def), 
                new SqliteParameter("@ans", ans), 
                new SqliteParameter("@m", mastered), 
                new SqliteParameter("@id", cardId)
                );
        }

        public void UpdateMastery(string cardId, bool mastered)
        {
            var c = Cards.FirstOrDefault(x => x.CardID == cardId);
            if (c == null) return;
            c.Mastered = mastered;
            ExecuteNonQuery("UPDATE Flashcard SET Mastered = @m WHERE CardID = @id",
                new SqliteParameter("@m", mastered), 
                new SqliteParameter("@id", cardId)
                );
        }

        public void DeleteCard(string cardId)
        {
            Cards.RemoveAll(c => c.CardID == cardId);
            ExecuteNonQuery("DELETE FROM Flashcard WHERE CardID = @id", new SqliteParameter("@id", cardId));
        }

        private void ExecuteNonQuery(string query, params SqliteParameter[] p)
        {
            using var conn = new SqliteConnection(_connectionString);
            conn.Open();
            using (var pragma = new SqliteCommand("PRAGMA foreign_keys = ON;", conn)) pragma.ExecuteNonQuery();
            using var cmd = new SqliteCommand(query, conn);
            cmd.Parameters.AddRange(p);
            cmd.ExecuteNonQuery();
        }
    }
}
