#nullable disable
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicketMate
{
    public partial class SeatSelectionForm : Form
    {
        private Bus selectedBus;
        private List<int> selectedSeats;

        public SeatSelectionForm(Bus bus)
        {
            InitializeComponent();
            selectedBus = bus;
            selectedSeats = new List<int>();
            CreateSeatMap();
        }

        private void CreateSeatMap()
        {
            this.Text = $"Select Seat - {selectedBus.Name}";
            this.BackColor = Color.FromArgb(250, 240, 240);
            this.ClientSize = new Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            int totalSeats = selectedBus.TotalSeats;
            int seatNumber = 1;
            int rows = 5;
            int cols = 5;
            int buttonSize = 50;
            int padding = 10;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (seatNumber > totalSeats)
                        break;

                    Button seatButton = new Button
                    {
                        Text = seatNumber.ToString(),
                        Width = buttonSize,
                        Height = buttonSize,
                        Left = 50 + col * (buttonSize + padding),
                        Top = 50 + row * (buttonSize + padding),
                        BackColor = Color.LightGreen,
                        Tag = seatNumber
                    };

                    seatButton.Click += SeatButton_Click;
                    this.Controls.Add(seatButton);
                    seatNumber++;
                }
            }

            Button confirmButton = new Button
            {
                Text = "Confirm Selection",
                BackColor = Color.FromArgb(134, 10, 121),
                ForeColor = Color.White,
                Width = 180,
                Height = 40,
                Top = 400,
                Left = (this.ClientSize.Width - 180) / 2
            };

            confirmButton.Click += ConfirmButton_Click;
            this.Controls.Add(confirmButton);
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton == null)
                return;

            int seatNum = (int)clickedButton.Tag;

            if (clickedButton.BackColor == Color.LightGreen)
            {
                clickedButton.BackColor = Color.LightBlue;
                selectedSeats.Add(seatNum);
            }
            else if (clickedButton.BackColor == Color.LightBlue)
            {
                clickedButton.BackColor = Color.LightGreen;
                selectedSeats.Remove(seatNum);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Please select at least one seat first.");
                return;
            }

            try
            {
                var bookingCollection = DatabaseHelper.GetCollection<Booking>("Bookings");

                foreach (var seat in selectedSeats)
                {
                    Booking booking = new Booking
                    {
                        BusName = selectedBus.Name,
                        DepartureCity = selectedBus.DepartureCity,
                        DestinationCity = selectedBus.DestinationCity,
                        DepartureTime = selectedBus.DepartureTime,
                        ArrivalTime = selectedBus.ArrivalTime,
                        SeatNumber = seat,
                        BookingDate = DateTime.Now
                    };

                    bookingCollection.InsertOne(booking);
                }

                MessageBox.Show($"Seats {string.Join(", ", selectedSeats)} booked successfully!");

                // After booking, move to next form (Boarding Details / Guest Info)
                BoardingDetailsForm boardingForm = new BoardingDetailsForm(selectedSeats[0].ToString());
                boardingForm.Show();
                this.Hide();
                new GuestInformationForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during booking: {ex.Message}");
            }
        }
    }

    public class Booking
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string BusName { get; set; }
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public int SeatNumber { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
