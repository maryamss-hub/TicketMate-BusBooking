#nullable disable
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicketMate
{
    partial class LoginForm
    {
        private IContainer components = null;

        // Labels
        private Label labelTitle;
        private Label labelSubtitle;
        private Label labelEmail;
        private Label labelPassword;
        private Label labelOrSignIn;

        // Panels + TextBoxes
        private Panel panelEmail;
        private TextBox textEmail;
        private Panel panelPassword;
        private TextBox textPassword;

        // Check box & links
        private CheckBox keepSignedIn;
        private LinkLabel linkForgotPassword;
        private LinkLabel linkSignup;

        // Buttons (rounded/pill)
        private Button buttonLogin;
        private Button buttonGoogle;

        /// <summary>
        /// Dispose override
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Initialize all controls (Designer).
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelSubtitle = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            labelOrSignIn = new Label();
            panelEmail = new Panel();
            textEmail = new TextBox();
            panelPassword = new Panel();
            textPassword = new TextBox();
            keepSignedIn = new CheckBox();
            linkForgotPassword = new LinkLabel();
            linkSignup = new LinkLabel();
            buttonLogin = new Button();
            buttonGoogle = new Button();
            panelEmail.SuspendLayout();
            panelPassword.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Azure;
            labelTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(125, 25, 112);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(120, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Login";
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Segoe UI", 12F);
            labelSubtitle.ForeColor = Color.FromArgb(159, 86, 158);
            labelSubtitle.Location = new Point(0, 0);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(235, 28);
            labelSubtitle.TabIndex = 1;
            labelSubtitle.Text = "Welcome back to the app";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F);
            labelEmail.ForeColor = Color.FromArgb(0, 30, 57);
            labelEmail.Location = new Point(0, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(116, 23);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email Address";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10F);
            labelPassword.ForeColor = Color.FromArgb(0, 30, 57);
            labelPassword.Location = new Point(0, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(80, 23);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // labelOrSignIn
            // 
            labelOrSignIn.AutoSize = true;
            labelOrSignIn.Font = new Font("Segoe UI", 9F);
            labelOrSignIn.ForeColor = Color.FromArgb(0, 30, 57);
            labelOrSignIn.Location = new Point(0, 0);
            labelOrSignIn.Name = "labelOrSignIn";
            labelOrSignIn.Size = new Size(102, 20);
            labelOrSignIn.TabIndex = 9;
            labelOrSignIn.Text = "or sign in with";
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.White;
            panelEmail.Controls.Add(textEmail);
            panelEmail.Location = new Point(0, 0);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(200, 100);
            panelEmail.TabIndex = 3;
            panelEmail.Paint += panelEmail_Paint;
            // 
            // textEmail
            // 
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Font = new Font("Segoe UI", 14F);
            textEmail.ForeColor = Color.FromArgb(191, 191, 191);
            textEmail.Location = new Point(0, 0);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(100, 32);
            textEmail.TabIndex = 0;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.White;
            panelPassword.Controls.Add(textPassword);
            panelPassword.Location = new Point(0, 0);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(200, 100);
            panelPassword.TabIndex = 5;
            panelPassword.Paint += panelPassword_Paint;
            // 
            // textPassword
            // 
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Segoe UI", 14F);
            textPassword.ForeColor = Color.FromArgb(191, 191, 191);
            textPassword.Location = new Point(0, 0);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(100, 32);
            textPassword.TabIndex = 0;
            textPassword.UseSystemPasswordChar = true;
            // 
            // keepSignedIn
            // 
            keepSignedIn.AutoSize = true;
            keepSignedIn.Font = new Font("Segoe UI", 9F);
            keepSignedIn.ForeColor = Color.FromArgb(0, 30, 57);
            keepSignedIn.Location = new Point(0, 0);
            keepSignedIn.Name = "keepSignedIn";
            keepSignedIn.Size = new Size(154, 24);
            keepSignedIn.TabIndex = 6;
            keepSignedIn.Text = "Keep me signed in";
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Font = new Font("Segoe UI", 9F);
            linkForgotPassword.LinkColor = Color.FromArgb(100, 8, 85);
            linkForgotPassword.Location = new Point(0, 0);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(125, 20);
            linkForgotPassword.TabIndex = 7;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forgot Password?";
            // 
            // linkSignup
            // 
            linkSignup.Font = new Font("Segoe UI", 10F);
            linkSignup.LinkColor = Color.FromArgb(146, 55, 120);
            linkSignup.Location = new Point(0, 0);
            linkSignup.Name = "linkSignup";
            linkSignup.Size = new Size(100, 23);
            linkSignup.TabIndex = 11;
            linkSignup.TabStop = true;
            linkSignup.Text = "Create an account";
            linkSignup.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            buttonLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonLogin.BackColor = Color.FromArgb(134, 10, 121);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(0, 0);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 8;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // buttonGoogle
            // 
            buttonGoogle.BackColor = Color.FromArgb(191, 191, 191);
            buttonGoogle.FlatAppearance.BorderSize = 0;
            buttonGoogle.FlatStyle = FlatStyle.Flat;
            buttonGoogle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonGoogle.ForeColor = Color.FromArgb(0, 30, 57);
            buttonGoogle.Location = new Point(0, 0);
            buttonGoogle.Name = "buttonGoogle";
            buttonGoogle.Size = new Size(75, 23);
            buttonGoogle.TabIndex = 10;
            buttonGoogle.Text = "Continue with Google";
            buttonGoogle.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AcceptButton = buttonLogin;
            ClientSize = new Size(414, 736);
            Controls.Add(labelTitle);
            Controls.Add(labelSubtitle);
            Controls.Add(labelEmail);
            Controls.Add(panelEmail);
            Controls.Add(labelPassword);
            Controls.Add(panelPassword);
            Controls.Add(keepSignedIn);
            Controls.Add(linkForgotPassword);
            Controls.Add(buttonLogin);
            Controls.Add(labelOrSignIn);
            Controls.Add(buttonGoogle);
            Controls.Add(linkSignup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            Paint += LoginForm_Paint;
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // ========== Paint: pink gradient background ==========
        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                ColorTranslator.FromHtml("#FEEEF0"),  // top
                ColorTranslator.FromHtml("#F8F8F8"),  // bottom
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        // ========== Load: layout + rounding ==========
        private void LoginForm_Load(object sender, System.EventArgs e)
        {
            PerformLayoutCustom();

            // Round corners for Email/Password panels and pill shape for buttons
            RoundControlCorners(panelEmail, 16);
            RoundControlCorners(panelPassword, 16);
            RoundControlCorners(buttonLogin, 30);   // half of ~50–60 height
            RoundControlCorners(buttonGoogle, 30);
        }

        // ========== Manual layout method ==========
        private void PerformLayoutCustom()
        {
            int formWidth = this.ClientSize.Width; // 414
            int xCenter = formWidth / 2;
            int currentY = 40;

            // Title: center horizontally
            labelTitle.Left = xCenter - (labelTitle.Width / 2);
            labelTitle.Top = currentY;
            currentY += labelTitle.Height + 5;

            // Subtitle: center horizontally
            labelSubtitle.Left = xCenter - (labelSubtitle.Width / 2);
            labelSubtitle.Top = currentY;
            currentY += labelSubtitle.Height + 25;

            // labelEmail
            labelEmail.Left = 50;
            labelEmail.Top = currentY;
            currentY += labelEmail.Height + 5;

            // panelEmail
            panelEmail.Left = 50;
            panelEmail.Top = currentY;
            panelEmail.Width = 314;  // 414 - 2*50 = 314
            panelEmail.Height = 44;
            textEmail.Left = 10;
            textEmail.Top = 8;
            textEmail.Width = panelEmail.Width - 20;
            currentY += panelEmail.Height + 15;

            // labelPassword
            labelPassword.Left = 50;
            labelPassword.Top = currentY;
            currentY += labelPassword.Height + 5;

            // panelPassword
            panelPassword.Left = 50;
            panelPassword.Top = currentY;
            panelPassword.Width = 314;
            panelPassword.Height = 44;
            textPassword.Left = 10;
            textPassword.Top = 8;
            textPassword.Width = panelPassword.Width - 20;
            currentY += panelPassword.Height + 10;

            // keepSignedIn + linkForgotPassword on the same row
            keepSignedIn.Left = 50;
            keepSignedIn.Top = currentY;

            linkForgotPassword.Top = currentY;
            linkForgotPassword.Left = (50 + 314) - linkForgotPassword.Width;
            currentY += Math.Max(keepSignedIn.Height, linkForgotPassword.Height) + 25;

            // buttonLogin
            buttonLogin.Left = 50;
            buttonLogin.Top = currentY;
            buttonLogin.Width = 314;
            buttonLogin.Height = 48;
            currentY += buttonLogin.Height + 20;

            // labelOrSignIn: center horizontally
            labelOrSignIn.Left = xCenter - (labelOrSignIn.Width / 2);
            labelOrSignIn.Top = currentY;
            currentY += labelOrSignIn.Height + 15;

            // buttonGoogle
            buttonGoogle.Left = 50;
            buttonGoogle.Top = currentY;
            buttonGoogle.Width = 314;
            buttonGoogle.Height = 48;
            currentY += buttonGoogle.Height + 30;

            // linkSignup: center horizontally
            linkSignup.Left = xCenter - (linkSignup.Width / 2);
            linkSignup.Top = currentY;
        }

        // ========== panelEmail Paint (1px border) ==========
        private void panelEmail_Paint(object sender, PaintEventArgs e)
        {
            // e.g., 1px solid ~rgba(211,0,176,0.3)
            using (var pen = new Pen(Color.FromArgb(77, 211, 0, 176), 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0, 0,
                    panelEmail.Width - 1,
                    panelEmail.Height - 1);
            }
        }

        // ========== panelPassword Paint (1px border) ==========
        private void panelPassword_Paint(object sender, PaintEventArgs e)
        {
            // e.g., 1px solid ~rgba(156,70,152,0.3)
            using (var pen = new Pen(Color.FromArgb(77, 156, 70, 152), 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0, 0,
                    panelPassword.Width - 1,
                    panelPassword.Height - 1);
            }
        }

        // ========== Helper: round corners ==========
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
    }
}
