using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Models
{
    public class User
    {
        public string UserID { get; set; } = Guid.NewGuid().ToString();
        public string Nickname { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public bool IsPomodoroEnabled { get; set; } 
        public int TimerWorkLength { get; set; }
        public int TimerBreakLength { get; set; }
    }
}
