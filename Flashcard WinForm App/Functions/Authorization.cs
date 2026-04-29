using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using BCrypt.Net;

namespace Flashcard_WinForm_App.Functions
{
    public class Authorization
    {
        public bool RegisterUser(string username, string password, string nickname) //registers new user, return false if already existing, otherwise true
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);  //hash pw

            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString)) //connect to db
            {
                connection.Open();

                using (var checkCmd = connection.CreateCommand())
                {
                    checkCmd.CommandText = "SELECT COUNT(*) FROM User WHERE Username = @username";
                    checkCmd.Parameters.AddWithValue("@username", username);

                    object? scalar = checkCmd.ExecuteScalar();
                    long userCount = 0;
                    if (scalar is long l) userCount = l;
                    else if (scalar != null && scalar != DBNull.Value) userCount = Convert.ToInt64(scalar);

                    if (userCount > 0)
                    {
                        return false; //user already exists
                    }
                }

                using (var insertCmd = connection.CreateCommand())
                {
                    insertCmd.CommandText = "INSERT INTO User (Username, PasswordHash, Nickname) VALUES (@username, @passwordHash, @nickname)";
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@passwordHash", passwordHash);
                    insertCmd.Parameters.AddWithValue("@nickname", nickname);
                    insertCmd.ExecuteNonQuery();
                }

                return true; //user registered
            }
        }

        public Flashcard_WinForm_App.Models.User LoginUser(string username, string password) //returns true if login successful, otherwise false
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString)) //connect to db
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT UserID, Nickname, PasswordHash, Config FROM User WHERE Username = $user";
                    cmd.Parameters.AddWithValue("$user", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null; //user not found
                        }
                        string storedHash = reader.GetString(2);
                        if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                        {
                            int configOrdinal = reader.GetOrdinal("Config");
                            return new Flashcard_WinForm_App.Models.User
                            {
                                UserID = reader.GetInt32(0),
                                Nickname = reader.GetString(1),
                                Username = username,
                                PasswordHash = storedHash,
                                Config = reader.IsDBNull(configOrdinal) ? null : (byte[])reader["Config"]
                            };
                        }
                        else
                        {
                            return null; //invalid password
                        }
                    }
                }
            }
        }
    }
}
