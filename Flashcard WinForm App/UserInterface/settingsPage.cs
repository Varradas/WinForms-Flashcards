using Flashcard_WinForm_App.Data;
using Flashcard_WinForm_App.Functions;
using Flashcard_WinForm_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flashcard_WinForm_App.UserInterface
{
    public partial class settingsPage : UserControl
    {
        Manager _manager = GlobalData.Manager;
        User currentUser;
        public settingsPage(User user)
        {
            InitializeComponent();
            Theme.ApplyTheme(this);
            btnDeleteUser.BackColor = Color.Red;
            currentUser = user;
            if (currentUser.IsPomodoroEnabled)
            {
                pnlContent.Visible = true;
                numBreakTime.Enabled = true;
                numWorkTime.Enabled = true;
                chkEnableTimer.Checked = true;
            }
            else
            {
                pnlContent.Visible = false;
                numBreakTime.Enabled = false;
                numWorkTime.Enabled = false;
            }
        }

        private void chkEnableTimer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableTimer.Checked)
            {
                pnlContent.Visible = true;
                numBreakTime.Enabled = true;
                numWorkTime.Enabled = true;
                numBreakTime.Value = currentUser.TimerBreakLength;
                numWorkTime.Value = currentUser.TimerWorkLength;
            }
            else
            {
                pnlContent.Visible = false;
                numBreakTime.Enabled = false;
                numWorkTime.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _manager.UpdateUserConfig(currentUser.UserID, chkEnableTimer.Checked, (int)numWorkTime.Value, (int)numBreakTime.Value);
            MessageBox.Show("Settings saved!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var homePageControl = new global::Flashcard_WinForm_App.UserInterface.homePage(currentUser);

            Form? parent = this.ParentForm;
            if (parent is INavigation nav)
            {
                nav.ShowPage(homePageControl);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _manager.DeleteUser(currentUser.UserID);
                var loginPageControl = new global::Flashcard_WinForm_App.UserInterface.loginPage();

                Form? parent = this.ParentForm;
                if (parent is INavigation nav)
                {
                    nav.ShowPage(loginPageControl);
                }
            }
        }
    }
}
