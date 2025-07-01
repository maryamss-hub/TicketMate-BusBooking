#nullable disable
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TicketMate
{
    partial class SignupForm
    {
        private IContainer components = null;

        // Designer fields
        private Label labelTitle;
        private Label labelSubtitle;
        private Label labelName;
        private Label labelEmail;
        private Label labelPassword;
        private Label labelTerms;
        private LinkLabel linkSignInHere;

        private Panel panelName;
        private TextBox textName;

        private Panel panelEmail;
        private TextBox textEmail;

        private Panel panelPassword;
        private TextBox textPassword;

        private Panel panelCheckbox;

        private Button buttonSignUp;
        private Button buttonGoogle;

        /// <summary>
        /// Dispose override
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Auto-generated method to initialize and configure all controls.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new Container();

            // -------------- Form --------------
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(414, 736);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sign Up - TicketMate";

            // -------------- Instantiate controls --------------
            labelTitle = new Label();
            labelSubtitle = new Label();
            labelName = new Label();
            panelName = new Panel();
            textName = new TextBox();

            labelEmail = new Label();
            panelEmail = new Panel();
            textEmail = new TextBox();

            labelPassword = new Label();
            panelPassword = new Panel();
            textPassword = new TextBox();

            panelCheckbox = new Panel();
            labelTerms = new Label();

            buttonSignUp = new Button();
            buttonGoogle = new Button();
            linkSignInHere = new LinkLabel();

            // -------------- Configure each control --------------

            // labelTitle
            labelTitle.Text = "Create an account";
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Purple;
            labelTitle.AutoSize = true;

            // labelSubtitle
            labelSubtitle.Text = "Welcome back to the app";
            labelSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            labelSubtitle.ForeColor = Color.MediumPurple;
            labelSubtitle.AutoSize = true;

            // labelName
            labelName.Text = "Name";
            labelName.Font = new Font("Segoe UI", 9F);
            labelName.ForeColor = Color.Black;
            labelName.AutoSize = true;

            // panelName
            panelName.BackColor = Color.White;
            panelName.Size = new Size(300, 40);

            // textName
            textName.BorderStyle = BorderStyle.None;
            textName.Font = new Font("Segoe UI", 10F);
            textName.ForeColor = Color.Gray;
            textName.Width = 280;
            textName.Left = 10;
            textName.Top = 8;
            // If on .NET 6+, you could do:
            // textName.PlaceholderText = "John Doe";
            panelName.Controls.Add(textName);

            // labelEmail
            labelEmail.Text = "Email Address";
            labelEmail.Font = new Font("Segoe UI", 9F);
            labelEmail.ForeColor = Color.Black;
            labelEmail.AutoSize = true;

            // panelEmail
            panelEmail.BackColor = Color.White;
            panelEmail.Size = new Size(300, 40);

            // textEmail
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Font = new Font("Segoe UI", 10F);
            textEmail.ForeColor = Color.Gray;
            textEmail.Width = 280;
            textEmail.Left = 10;
            textEmail.Top = 8;
            // textEmail.PlaceholderText = "hello@example.com"; // if .NET 6+
            panelEmail.Controls.Add(textEmail);

            // labelPassword
            labelPassword.Text = "Password";
            labelPassword.Font = new Font("Segoe UI", 9F);
            labelPassword.ForeColor = Color.Black;
            labelPassword.AutoSize = true;

            // panelPassword
            panelPassword.BackColor = Color.White;
            panelPassword.Size = new Size(300, 40);

            // textPassword
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Segoe UI", 10F);
            textPassword.ForeColor = Color.Gray;
            textPassword.UseSystemPasswordChar = true;
            textPassword.Width = 280;
            textPassword.Left = 10;
            textPassword.Top = 8;
            // textPassword.PlaceholderText = "••••••••"; // if .NET 6+
            panelPassword.Controls.Add(textPassword);

            // panelCheckbox
            panelCheckbox.BackColor = Color.Purple;
            panelCheckbox.Size = new Size(14, 14);

            // labelTerms
            labelTerms.Text = "By continuing, you agree to our terms of service.";
            labelTerms.Font = new Font("Segoe UI", 9F);
            labelTerms.ForeColor = Color.Gray;
            labelTerms.AutoSize = true;

            // buttonSignUp
            buttonSignUp.Text = "Sign up";
            buttonSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSignUp.ForeColor = Color.White;
            buttonSignUp.BackColor = Color.FromArgb(153, 0, 153);
            buttonSignUp.FlatStyle = FlatStyle.Flat;
            buttonSignUp.Size = new Size(300, 45);
            buttonSignUp.FlatAppearance.BorderSize = 0;

            // buttonGoogle
            buttonGoogle.Text = "Continue with Google";
            buttonGoogle.Font = new Font("Segoe UI", 10F);
            buttonGoogle.ForeColor = Color.Black;
            buttonGoogle.BackColor = Color.LightGray;
            buttonGoogle.FlatStyle = FlatStyle.Flat;
            buttonGoogle.Size = new Size(300, 45);
            buttonGoogle.FlatAppearance.BorderSize = 0;

            // linkSignInHere
            linkSignInHere.Text = "Already have an account? Sign in here";
            linkSignInHere.Font = new Font("Segoe UI", 9F);
            linkSignInHere.LinkColor = Color.MediumVioletRed;
            linkSignInHere.AutoSize = true;

            // -------------- Add controls to the form --------------
            Controls.Add(labelTitle);
            Controls.Add(labelSubtitle);

            Controls.Add(labelName);
            Controls.Add(panelName);

            Controls.Add(labelEmail);
            Controls.Add(panelEmail);

            Controls.Add(labelPassword);
            Controls.Add(panelPassword);

            Controls.Add(panelCheckbox);
            Controls.Add(labelTerms);

            Controls.Add(buttonSignUp);
            Controls.Add(buttonGoogle);
            Controls.Add(linkSignInHere);

            // Final form config
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
