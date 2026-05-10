using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Models
{
    public class User
    {
        public string UserID { get; set; } = Guid.NewGuid().ToString();
        public string Nickname { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public bool IsPomodoroEnabled { get; set; } 
        public int TimerWorkLength { get; set; }
        public int TimerBreakLength { get; set; }
    }
}
