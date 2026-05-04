using BCrypt.Net;
using Flashcard_WinForm_App.Data;
using Flashcard_WinForm_App.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Functions
{
    public class Authorization
    {
        private Manager _manager = GlobalData.Manager;

        public bool RegisterUser(string username, string password, string nickname)
        {
            bool userExists = _manager.Users.Any(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (userExists) return false;

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            var newUser = new User
            {
                Username = username,
                PasswordHash = passwordHash,
                Nickname = nickname
            };

            _manager.CreateUser(newUser);

            return true;
        }

        public User LoginUser(string username, string password)
        {
            var user = _manager.Users.FirstOrDefault(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null) return null;

            if (BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                return user; // Success
            }

            return null; // Wrong password
        }
    }
}