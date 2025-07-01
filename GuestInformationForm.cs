#nullable disable
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicketMate
{
    public partial class GuestInformationForm : Form
    {
        private TextBox txtPassenger1Name;
        private TextBox txtPassenger1Age;
        private TextBox txtMobile;
        private TextBox txtEmail;

        public GuestInformationForm()
        {
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Guest Information";
            this.ClientSize = new Size(423, 736);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            Label title = new Label
            {
                Text = "Traveller Information",
                Font = new Font("Inter", 14, FontStyle.Bold),
                Location = new Point(30, 20),
                AutoSize = true
            };
            this.Controls.Add(title);

            AddPassengerSection("Passenger 1", 60);
            AddContactSection(390);
            AddProceedButton();
        }

        private void AddPassengerSection(string title, int top)
        {
            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Inter", 12, FontStyle.Bold),
                Location = new Point(30, top),
                AutoSize = true
            };
            this.Controls.Add(lblTitle);

            txtPassenger1Name = new TextBox
            {
                PlaceholderText = "Full Name",
                Size = new Size(320, 30),
                Location = new Point(30, top + 30),
                BackColor = Color.FromArgb(245, 245, 245)
            };

            txtPassenger1Age = new TextBox
            {
                PlaceholderText = "Age",
                Size = new Size(100, 30),
                Location = new Point(30, top + 70),
                BackColor = Color.FromArgb(245, 245, 245)
            };

            this.Controls.Add(txtPassenger1Name);
            this.Controls.Add(txtPassenger1Age);
        }

        private void AddContactSection(int top)
        {
            Label lblContact = new Label
            {
                Text = "Contact Information",
                Font = new Font("Inter", 14, FontStyle.Bold),
                Location = new Point(30, top),
                AutoSize = true
            };
            this.Controls.Add(lblContact);

            txtMobile = new TextBox
            {
                PlaceholderText = "Mobile",
                Size = new Size(320, 30),
                Location = new Point(30, top + 30),
                BackColor = Color.FromArgb(245, 245, 245)
            };

            txtEmail = new TextBox
            {
                PlaceholderText = "Email",
                Size = new Size(320, 30),
                Location = new Point(30, top + 70),
                BackColor = Color.FromArgb(245, 245, 245)
            };

            this.Controls.Add(txtMobile);
            this.Controls.Add(txtEmail);
        }

        private void AddProceedButton()
        {
            Button proceedBtn = new Button
            {
                Text = "Proceed to Book",
                Size = new Size(320, 40),
                Location = new Point(50, 650),
                BackColor = Color.FromArgb(138, 34, 111),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Inter", 14, FontStyle.Bold)
            };

            proceedBtn.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtPassenger1Name.Text) || string.IsNullOrWhiteSpace(txtMobile.Text))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                // Save guest info into MongoDB
                var guestCollection = DatabaseHelper.GetCollection<GuestInfo>("GuestInformation");

                GuestInfo guest = new GuestInfo
                {
                    FullName = txtPassenger1Name.Text.Trim(),
                    Age = txtPassenger1Age.Text.Trim(),
                    Mobile = txtMobile.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    BookingDate = DateTime.Now
                };

                guestCollection.InsertOne(guest);

                MessageBox.Show("Guest Information Saved Successfully!");

                // Move to Payment screen (you can open payment form here if you have it)
            };

            this.Controls.Add(proceedBtn);
        }
    }

    public class GuestInfo
    {
        public string FullName { get; set; }
        public string Age { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
