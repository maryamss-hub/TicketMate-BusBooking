#nullable disable
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TicketMate
{
    public partial class LoginForm : Form
    {
        internal bool IsLoggedIn = false;

        public LoginForm()
        {
            InitializeComponent();

            buttonLogin.Click += ButtonLogin_Click;
            buttonGoogle.Click += ButtonGoogle_Click;
            linkForgotPassword.Click += LinkForgotPassword_Click;
            linkSignup.Click += LinkSignup_Click;
            this.FormClosing += LoginForm_FormClosing;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text.Trim();
            string password = textPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            var user = UserManager.Authenticate(email, password);

            if (user != null)
            {
                IsLoggedIn = true;
                MessageBox.Show($"Welcome {user.Name}!");

                // Navigate to Bus Search Form
                BusSearchForm busSearchForm = new BusSearchForm();
                Program.ShowForm(busSearchForm, this);
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }

        private void ButtonGoogle_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://accounts.google.com",
                UseShellExecute = true
            });
        }

        private void LinkForgotPassword_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
                MessageBox.Show("Enter your email to receive the reset link.");
            else
                MessageBox.Show($"A reset link has been sent to {email}.");
        }

        private void LinkSignup_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm();
            Program.ShowForm(signupForm, this);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLoggedIn && e.CloseReason == CloseReason.UserClosing)
            {
                Program.WelcomeInstance?.Show();
            }
        }

        // Empty event handlers
        private void labelSubtitle_Click(object sender, EventArgs e) { }
        private void labelTitle_Click(object sender, EventArgs e) { }
    }
}
