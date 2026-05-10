using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Data
{
    // Flashcard_WinForm_App.Data.DBPath.ConnectionString
    public static class DBPath
    {
        //public static string ConnectionString { get; } = $"Data Source = database.db";
        private static string BasePath = AppDomain.CurrentDomain.BaseDirectory;

        // This combines that folder path with your database filename
        public static string ConnectionString { get; } =
            $"Data Source={Path.Combine(BasePath,"Data", "database.db")}";

    }
}
