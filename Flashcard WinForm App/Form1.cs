using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Flashcard_WinForm_App.Models;

namespace Flashcard_WinForm_App
{
    public partial class Form1 : Form, Functions.INavigation
    {
        private Control _originalTimerParent;
        public Form1()
        {
            InitializeComponent();
            pomodoroTimer.OnBreakStarted += HandleBreakStarted;
            pomodoroTimer.OnBreakEnded += HandleBreakEnded;
        }

        private void Form1_Load(object sender, EventArgs e) //put splash screen here, then open login form
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate(); 
            this.TopMost = true; 
            this.TopMost = false;
            pnlLockOverlay.BackColor = Color.FromArgb(200, 45, 45, 45);
            pomodoroTimer.BringToFront();
            pomodoroTimer.Visible = false;
            if (this.ParentForm is Form1 mainForm)
            {
                mainForm.pomodoroTimer.Visible = false;
                mainForm.pomodoroTimer.Enabled = false;
            }
            var loginPageControl = new global::Flashcard_WinForm_App.UserInterface.loginPage();
            ShowPage(loginPageControl);
        }

        public void ShowPage(UserControl page)
        {
            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose(); 
            }
            pnlContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(page);
        }

        public void ResizeHost(int width, int height)
        {
            this.Size = new Size(width, height);
            this.CenterToScreen();
        }

        public void LockSize(bool lockSize)
        {
            if (lockSize)
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.MaximizeBox = true;
            }
        }

        private void HandleBreakStarted(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f != this)
                {
                    f.Enabled = false;
                    f.WindowState = FormWindowState.Minimized;
                }
            }

            pnlLockOverlay.Visible = true;
            pnlLockOverlay.BringToFront();
            pomodoroTimer.Parent = pnlLockOverlay;

            pomodoroTimer.Location = new Point(360, (pnlLockOverlay.Height - pomodoroTimer.Height) / 2);
            pomodoroTimer.BringToFront();
            pomodoroTimer.Size = new Size(63, 34);
            pomodoroTimer.BackColor = Color.Transparent;
            pomodoroTimer.ForeColor = Color.White;
            label1.BackColor = Color.FromArgb(0, 255, 255, 255);
            this.Activate();
            this.BringToFront();
        }

        private void HandleBreakEnded(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                f.Enabled = true;
                if (f != this && f.WindowState == FormWindowState.Minimized)
                {
                    f.WindowState = FormWindowState.Normal; 
                }
            }

            pomodoroTimer.Parent = this;
            pomodoroTimer.BackColor = this.BackColor;
            pomodoroTimer.Location = new Point(550, 0);
            pomodoroTimer.ForeColor = Color.Black;
            pomodoroTimer.Size = new Size(177, 34);
            pomodoroTimer.BringToFront();   

            pnlLockOverlay.Visible = false;
            pomodoroTimer.StartTimer();
        }

        public void ApplyPomodoroSettings(User user)
        {
            if (user.IsPomodoroEnabled)
            {
                pomodoroTimer.Visible = true;
                pomodoroTimer.BringToFront();
                pomodoroTimer.WorkDurationMinutes = user.TimerWorkLength;
                pomodoroTimer.BreakDurationMinutes = user.TimerBreakLength;

                pomodoroTimer.StopTimer();
            }
            else
            {
                pomodoroTimer.Visible = false;
                pomodoroTimer.StopTimer();
            }
        }
    }
}
