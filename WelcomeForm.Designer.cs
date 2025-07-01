using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicketMate
{
    public partial class WelcomeForm : Form
    {
        private IContainer? components = null;
        private PictureBox? pictureBoxLogo;
        private Label? labelTitle;
        private Label? labelSubtitle;
        private LinkLabel? linkCreateAccount;
        private Panel? indicatorPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(WelcomeForm));
            pictureBoxLogo = new PictureBox();
            labelTitle = new Label();
            labelSubtitle = new Label();
            buttonGetStarted = new RoundedButton();
            linkCreateAccount = new LinkLabel();
            indicatorPanel = new Panel();
            ((ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(100, 80);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 200);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click_1;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.Purple;
            labelTitle.Location = new Point(50, 300);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 40);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Ticket Mate";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSubtitle
            // 
            labelSubtitle.BackColor = Color.Transparent;
            labelSubtitle.Font = new Font("Segoe UI", 10F);
            labelSubtitle.ForeColor = Color.MediumOrchid;
            labelSubtitle.Location = new Point(20, 340);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(360, 40);
            labelSubtitle.TabIndex = 2;
            labelSubtitle.Text = "Your One-Stop Ticket Booking Solution for Buses";
            labelSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonGetStarted
            // 
            buttonGetStarted.BackColor = Color.Purple;
            buttonGetStarted.FlatAppearance.BorderSize = 0;
            buttonGetStarted.FlatStyle = FlatStyle.Flat;
            buttonGetStarted.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonGetStarted.ForeColor = Color.White;
            buttonGetStarted.Location = new Point(100, 450);
            buttonGetStarted.Name = "buttonGetStarted";
            buttonGetStarted.Size = new Size(200, 50);
            buttonGetStarted.TabIndex = 4;
            buttonGetStarted.Text = "Get Started";
            buttonGetStarted.UseVisualStyleBackColor = false;
            // 
            // linkCreateAccount
            // 
            linkCreateAccount.Font = new Font("Segoe UI", 10F);
            linkCreateAccount.ForeColor = Color.DarkViolet;
            linkCreateAccount.LinkColor = Color.DarkViolet;
            linkCreateAccount.Location = new Point(100, 520);
            linkCreateAccount.Name = "linkCreateAccount";
            linkCreateAccount.Size = new Size(200, 20);
            linkCreateAccount.TabIndex = 5;
            linkCreateAccount.TabStop = true;
            linkCreateAccount.Text = "Create an account";
            linkCreateAccount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // indicatorPanel
            // 
            indicatorPanel.BackColor = Color.Transparent;
            indicatorPanel.ForeColor = Color.Purple;
            indicatorPanel.Location = new Point(160, 380);
            indicatorPanel.Name = "indicatorPanel";
            indicatorPanel.Size = new Size(80, 20);
            indicatorPanel.TabIndex = 3;
            // 
            // WelcomeForm
            // 
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(400, 700);
            Controls.Add(pictureBoxLogo);
            Controls.Add(labelTitle);
            Controls.Add(labelSubtitle);
            Controls.Add(indicatorPanel);
            Controls.Add(buttonGetStarted);
            Controls.Add(linkCreateAccount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket Mate - Welcome";
            Load += WelcomeForm_Load;
            ((ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        // Add Dots (Three Small Circles)
        private void AddDots()
        {
            for (int i = 0; i < 3; i++)
            {
                Panel dot = new Panel
                {
                    Size = new Size(20, 20),
                    Location = new Point(i * 25, 5),
                    BackColor = i == 0 ? Color.Purple : Color.LightGray, // First dot active
                    BorderStyle = BorderStyle.FixedSingle
                };
                indicatorPanel.Controls.Add(dot);
            }
        }

        // Gradient Background Effect
       

        private RoundedButton buttonGetStarted;
    }

    // Custom Rounded Button Class
    public class RoundedButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            int radius = 25;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}
