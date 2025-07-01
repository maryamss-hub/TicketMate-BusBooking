#nullable disable
using System;
using System.Windows.Forms;

namespace TicketMate
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            buttonGetStarted.Click += buttonGetStarted_Click;
            linkCreateAccount.Click += linkCreateAccount_Click;
            this.FormClosed += WelcomeForm_FormClosed;
        }

        private void buttonGetStarted_Click(object sender, EventArgs e)
        {
            Program.ShowLoginForm(this);
        }

        private void linkCreateAccount_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            Program.ShowForm(signupForm, this);
        }

        private void WelcomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ExitApplication();
        }

        // Empty event handlers
        private void buttonGetStarted_Click_1(object sender, EventArgs e) { }
        private void labelTitle_Click(object sender, EventArgs e) { }
        private void pictureBoxLogo_Click(object sender, EventArgs e) { }
        private void labelSubtitle_Click(object sender, EventArgs e) { }
        private void pictureBoxLogo_Click_1(object sender, EventArgs e) { }
        private void WelcomeForm_Load(object sender, EventArgs e) { }
    }
}
