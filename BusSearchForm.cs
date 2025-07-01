#nullable disable
using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TicketMate
{
    public partial class BusSearchForm : Form
    {
        public BusSearchForm()
        {
            InitializeComponent();

            buttonSearch.Click += ButtonSearch_Click;
            linkBack.Click += LinkBack_Click;
            this.FormClosing += BusSearchForm_FormClosing;
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string departure = textDeparture.Text.Trim();
            string destination = textDestination.Text.Trim();
            DateTime departureDate = datePicker.Value;

            if (string.IsNullOrWhiteSpace(departure) || departure == "From")
            {
                MessageBox.Show("Please enter a departure location.");
                return;
            }

            if (string.IsNullOrWhiteSpace(destination) || destination == "To")
            {
                MessageBox.Show("Please enter a destination location.");
                return;
            }

            if (departure.Equals(destination, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Departure and destination cannot be the same.");
                return;
            }

            try
            {
                var busCollection = DatabaseHelper.GetCollection<Bus>("buses"); // collection name must match "buses" ✅

                // FINAL CORRECT SEARCH - case-insensitive exact match
                var filter = Builders<Bus>.Filter.And(
                    Builders<Bus>.Filter.Regex("DepartureCity", new BsonRegularExpression($"^{departure}$", "i")),
                    Builders<Bus>.Filter.Regex("DestinationCity", new BsonRegularExpression($"^{destination}$", "i"))
                );

                var matchingBuses = busCollection.Find(filter).ToList();

                if (matchingBuses.Count == 0)
                {
                    MessageBox.Show("No buses found for the selected route.");
                    return;
                }

                BusResultsForm resultsForm = new BusResultsForm(matchingBuses, departure, destination, departureDate);
                this.Hide();
                resultsForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching buses: {ex.Message}");
            }
        }

        private void LinkBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.WelcomeInstance?.Show();
        }

        private void BusSearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Program.WelcomeInstance?.Show();
            }
        }
    }
}
