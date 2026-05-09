using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flashcard_WinForm_App
{
    public partial class Form1 : Form, Functions.INavigation
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //put splash screen here, then open login form
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate(); 
            this.TopMost = true; 
            this.TopMost = false;
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
    }
}
