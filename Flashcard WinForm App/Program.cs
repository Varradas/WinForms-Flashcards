using Microsoft.Data.Sqlite;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Flashcard_WinForm_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static SplashScreen Splash = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread splashThread = new Thread(new ThreadStart(ShowSplashScreen));
            splashThread.IsBackground = true;
            splashThread.Start();

            CheckDatabase();

            if (Splash != null && !Splash.IsDisposed)
            {
                Splash.Invoke(new Action(() => Splash.Close()));
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }

        static void ShowSplashScreen()
        {
            Splash = new SplashScreen();
            Application.Run(Splash);
        }

        static void CheckDatabase()
        {
            using (var connection = new SqliteConnection(Flashcard_WinForm_App.Data.DBPath.ConnectionString))
            {
                connection.Open();

                var cmd = new SqliteCommand("PRAGMA journal_mode=WAL;", connection);
                cmd.ExecuteNonQuery();

                //buffer
                Thread.Sleep(3000);
            }
        }
    }
}