#nullable disable
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicketMate
{
    public partial class SignupForm : Form
    {
        private Form previousForm;

        public bool IsNavigatingToLogin { get; private set; } = false;
        public bool IsRegistered { get; private set; } = false;

        public SignupForm()
        {
            InitializeComponent();
            WireUpEvents();
        }

        public SignupForm(Form prev)
        {
            InitializeComponent();
            previousForm = prev;
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            this.Paint += SignupForm_Paint;
            this.Shown += SignupForm_Shown;
            this.FormClosing += SignupForm_FormClosing;

            buttonSignUp.Click += ButtonSignUp_Click;
            buttonGoogle.Click += ButtonGoogle_Click;
            linkSignInHere.Click += LinkSignInHere_Click;
        }

        private void SignupForm_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new LinearGradientBrush(
                this.ClientRectangle,
                ColorTranslator.FromHtml("#FFE7F3"),
                ColorTranslator.FromHtml("#FFF5FA"),
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void SignupForm_Shown(object sender, EventArgs e)
        {
            PerformLayoutCustom();
            RoundControlCorners(panelName, 10);
            RoundControlCorners(panelEmail, 10);
            RoundControlCorners(panelPassword, 10);
            RoundControlCorners(buttonSignUp, buttonSignUp.Height / 2);
            RoundControlCorners(buttonGoogle, buttonGoogle.Height / 2);
            RoundControlCorners(panelCheckbox, 3);
        }

        private void PerformLayoutCustom()
        {
            int formWidth = this.ClientSize.Width;
            int xCenter = formWidth / 2;
            int currentY = 40;

            labelTitle.Left = xCenter - (labelTitle.Width / 2);
            labelTitle.Top = currentY;
            currentY += labelTitle.Height + 10;

            labelSubtitle.Left = xCenter - (labelSubtitle.Width / 2);
            labelSubtitle.Top = currentY;
            currentY += labelSubtitle.Height + 25;

            int leftMargin = 50;
            labelName.Left = leftMargin;
            labelName.Top = currentY;
            currentY += labelName.Height + 5;

            panelName.Left = leftMargin;
            panelName.Top = currentY;
            currentY += panelName.Height + 15;

            labelEmail.Left = leftMargin;
            labelEmail.Top = currentY;
            currentY += labelEmail.Height + 5;

            panelEmail.Left = leftMargin;
            panelEmail.Top = currentY;
            currentY += panelEmail.Height + 15;

            labelPassword.Left = leftMargin;
            labelPassword.Top = currentY;
            currentY += labelPassword.Height + 5;

            panelPassword.Left = leftMargin;
            panelPassword.Top = currentY;
            currentY += panelPassword.Height + 20;

            panelCheckbox.Left = leftMargin;
            panelCheckbox.Top = currentY + 2;
            labelTerms.Left = panelCheckbox.Right + 8;
            labelTerms.Top = currentY;
            currentY += Math.Max(panelCheckbox.Height, labelTerms.Height) + 20;

            buttonSignUp.Left = leftMargin;
            buttonSignUp.Top = currentY;
            currentY += buttonSignUp.Height + 15;

            buttonGoogle.Left = leftMargin;
            buttonGoogle.Top = currentY;
            currentY += buttonGoogle.Height + 20;

            linkSignInHere.Left = (this.ClientSize.Width - linkSignInHere.Width) / 2;
            linkSignInHere.Top = currentY;
        }

        private void RoundControlCorners(Control ctrl, int radius)
        {
            if (ctrl.Width < 1 || ctrl.Height < 1) return;

            Rectangle bounds = new Rectangle(0, 0, ctrl.Width, ctrl.Height);
            using (GraphicsPath path = new GraphicsPath())
            {
                int diameter = radius * 2;
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();
                ctrl.Region = new Region(path);
            }
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            string name = textName.Text.Trim();
            string email = textEmail.Text.Trim();
            string password = textPassword.Text;

            bool success = UserManager.RegisterUser(name, email, password);

            if (success)
            {
                IsRegistered = true;
                MessageBox.Show("Account created successfully! You can now log in.");

                var login = new LoginForm();
                login.Show();
                IsNavigatingToLogin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to create account. Email may already be in use or fields are invalid.");
            }
        }

        private void ButtonGoogle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Google sign-up is simulated.");
        }

        private void LinkSignInHere_Click(object sender, EventArgs e)
        {
            IsNavigatingToLogin = true;
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void SignupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsNavigatingToLogin && !IsRegistered && previousForm != null && !previousForm.IsDisposed)
            {
                previousForm.Show();
            }
        }
    }
}
