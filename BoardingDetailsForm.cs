#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicketMate
{
    public partial class BoardingDetailsForm : Form
    {
        private Label lblSelected;
        private ComboBox cmbBoarding;
        private ComboBox cmbDrop;

        public BoardingDetailsForm(string selectedSeat)
        {
            //InitializeComponent();
            CreateForm(selectedSeat);
        }

        private void CreateForm(string selectedSeat)
        {
            this.Text = "Boarding Details";
            this.ClientSize = new Size(423, 736);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            Label title = new Label
            {
                Text = "Boarding & Drop Details",
                Font = new Font("Inter", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(138, 34, 111),
                Location = new Point(30, 30),
                AutoSize = true
            };
            this.Controls.Add(title);

            Label date = new Label
            {
                Text = DateTime.Now.ToString("dd-MMM-yyyy | dddd"),
                Font = new Font("Inter", 12),
                ForeColor = Color.Gray,
                Location = new Point(30, 70),
                AutoSize = true
            };
            this.Controls.Add(date);

            lblSelected = new Label
            {
                Text = $"Selected Seat: {selectedSeat}",
                Font = new Font("Inter", 12, FontStyle.Bold),
                Location = new Point(30, 110),
                AutoSize = true
            };
            this.Controls.Add(lblSelected);

            Label boarding = new Label
            {
                Text = "Select Boarding Point:",
                Font = new Font("Inter", 10),
                Location = new Point(30, 160),
                AutoSize = true
            };
            this.Controls.Add(boarding);

            cmbBoarding = new ComboBox
            {
                Location = new Point(30, 190),
                Size = new Size(340, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbBoarding.Items.AddRange(new string[] {
                "G-9 Islamabad Terminal",
                "Faizabad Terminal",
                "Saddar Rawalpindi Terminal"
            });
            this.Controls.Add(cmbBoarding);

            Label drop = new Label
            {
                Text = "Select Drop Point:",
                Font = new Font("Inter", 10),
                Location = new Point(30, 240),
                AutoSize = true
            };
            this.Controls.Add(drop);

            cmbDrop = new ComboBox
            {
                Location = new Point(30, 270),
                Size = new Size(340, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbDrop.Items.AddRange(new string[] {
                "Lahore City Terminal",
                "Thokar Niaz Baig Terminal",
                "Shahdara Terminal"
            });
            this.Controls.Add(cmbDrop);

            Button confirm = new Button
            {
                Text = "Proceed to Payment",
                Font = new Font("Inter", 12, FontStyle.Bold),
                Size = new Size(340, 40),
                Location = new Point(30, 330),
                BackColor = Color.FromArgb(138, 34, 111),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            confirm.Click += Confirm_Click;
            this.Controls.Add(confirm);
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (cmbBoarding.SelectedIndex == -1 || cmbDrop.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both boarding and drop points.");
                return;
            }

            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
            this.Hide();
        }
    }
}
