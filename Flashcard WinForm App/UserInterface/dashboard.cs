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
    public partial class dashboard : UserControl
    {
        Flashcard_WinForm_App.Models.User currentUser;
        public dashboard(Flashcard_WinForm_App.Models.User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            if (this.ParentForm is INavigation nav)
            {
                nav.ResizeHost(800, 600);
            }

            displayNickname.Text = $"Welcome, {currentUser.Nickname}!";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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
