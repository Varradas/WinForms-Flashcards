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
    public partial class registerPage : UserControl
    {
        private Flashcard_WinForm_App.Functions.Authorization auth = new Flashcard_WinForm_App.Functions.Authorization();

        public registerPage()
        {
            InitializeComponent();
        }

        private void registerPage_Load(object sender, EventArgs e)
        {
            if (this.ParentForm is INavigation nav)
            {
                nav.ResizeHost(500, 500);
                nav.LockSize(true);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            string nickname = nicknameInput.Text;

            if (auth.RegisterUser(username, password, nickname) == true)
            {
                MessageBox.Show("Registered Succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var loginPageControl = new global::Flashcard_WinForm_App.UserInterface.loginPage();

            Form parent = this.ParentForm;
            if (parent is INavigation nav)
            {
                nav.ShowPage(loginPageControl);
            }
        }
    }
}
