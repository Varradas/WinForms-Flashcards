using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Nickname { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public byte[] Config { get; set; }
    }
}
