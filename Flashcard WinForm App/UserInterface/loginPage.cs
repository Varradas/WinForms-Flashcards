using Flashcard_WinForm_App.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_WinForm_App.UserInterface
{
    public partial class loginPage : UserControl
    {
        private Flashcard_WinForm_App.Functions.Authorization auth = new Flashcard_WinForm_App.Functions.Authorization();

        public loginPage()
        {
            InitializeComponent();
            Theme.ApplyTheme(this);
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            if (this.ParentForm is INavigation nav)
            {
                nav.ResizeHost(500, 500);
                nav.LockSize(true);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (auth.LoginUser(username, password) is Flashcard_WinForm_App.Models.User user)
            {
                var homePageControl = new global::Flashcard_WinForm_App.UserInterface.homePage(user);
                Form? parent = this.ParentForm;
                if (parent is INavigation nav)
                {
                    nav.ShowPage(homePageControl);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerPageControl = new global::Flashcard_WinForm_App.UserInterface.registerPage();

            Form? parent = this.ParentForm;
            if (parent is INavigation nav)
            {
                nav.ShowPage(registerPageControl);
            }
        }
    }
}
