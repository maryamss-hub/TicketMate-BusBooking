#nullable disable
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicketMate
{
    public partial class BusResultsForm : Form
    {
        private List<Bus> buses;
        private Panel selectedBusPanel = null;

        public BusResultsForm(List<Bus> matchingBuses, string departure, string destination, DateTime date)
        {
            InitializeComponent();
            this.buses = matchingBuses;
            SetupForm(departure, destination, date);
        }

        private void SetupForm(string departure, string destination, DateTime date)
        {
            this.BackColor = Color.FromArgb(250, 240, 240);
            this.Text = "Available Buses";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            Label lblTitle = new Label
            {
                Text = $"Buses from {departure} to {destination}",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(125, 25, 112),
                Location = new Point(30, 30),
                AutoSize = true
            };
            this.Controls.Add(lblTitle);

            Label lblDate = new Label
            {
                Text = date.ToString("dddd, MMMM d, yyyy"),
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(159, 86, 158),
                Location = new Point(30, 80),
                AutoSize = true
            };
            this.Controls.Add(lblDate);

            AddFilterControls(120);

            int yPos = 180;
            foreach (var bus in buses)
            {
                yPos = AddBusCard(bus, yPos);
            }

            AddBackButton(yPos + 20);
        }

        private void AddFilterControls(int yPos)
        {
            Panel filterPanel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(700, 50),
                Location = new Point(30, yPos)
            };

            ComboBox cmbSort = new ComboBox
            {
                Items = { "Sort by: Departure Time", "Price (Low to High)", "Price (High to Low)", "Duration" },
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(10, 10),
                Width = 200
            };
            cmbSort.SelectedIndexChanged += (s, e) => SortBuses(cmbSort.SelectedIndex);
            cmbSort.SelectedIndex = 0;

            filterPanel.Controls.Add(cmbSort);
            this.Controls.Add(filterPanel);
        }

        private int AddBusCard(Bus bus, int yPos)
        {
            Panel card = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(700, 120),
                Location = new Point(30, yPos),
                Tag = bus
            };

            Label lblName = new Label
            {
                Text = $"{bus.Name}  ★ {bus.Rating:0.0}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            TimeSpan duration = DateTime.Parse(bus.ArrivalTime) - DateTime.Parse(bus.DepartureTime);
            Label lblTimings = new Label
            {
                Text = $"{bus.DepartureTime} → {bus.ArrivalTime}  ({duration.Hours}h {duration.Minutes}m)",
                Location = new Point(10, 35),
                AutoSize = true
            };

            Label lblPrice = new Label
            {
                Text = $"Rs {bus.Price:n0}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 100, 0),
                Location = new Point(550, 10),
                AutoSize = true
            };

            FlowLayoutPanel featurePanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Location = new Point(10, 60),
                AutoSize = true
            };

            foreach (string feature in bus.Features)
            {
                featurePanel.Controls.Add(new Label
                {
                    Text = $"• {feature}",
                    Margin = new Padding(0, 0, 10, 0),
                    AutoSize = true
                });
            }

            Button btnSelect = new Button
            {
                Text = "Select",
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(134, 10, 121),
                ForeColor = Color.White,
                Size = new Size(100, 30),
                Location = new Point(550, 40),
                Tag = card
            };
            btnSelect.Click += (s, e) => SelectBus((Panel)((Button)s).Tag);

            card.Controls.Add(lblName);
            card.Controls.Add(lblTimings);
            card.Controls.Add(lblPrice);
            card.Controls.Add(featurePanel);
            card.Controls.Add(btnSelect);
            this.Controls.Add(card);

            return yPos + 130;
        }

        private void SelectBus(Panel busPanel)
        {
            if (selectedBusPanel != null)
            {
                selectedBusPanel.BackColor = Color.White;
                foreach (Control c in selectedBusPanel.Controls)
                {
                    if (c is Label lbl && lbl.Text.StartsWith("✓ "))
                        lbl.Text = lbl.Text.Substring(2);
                }
            }

            busPanel.BackColor = Color.FromArgb(240, 240, 255);
            selectedBusPanel = busPanel;

            foreach (Control c in busPanel.Controls)
            {
                if (c is Label lbl && lbl.Font.Bold)
                {
                    lbl.Text = "✓ " + lbl.Text;
                    break;
                }
            }

            Bus selectedBus = (Bus)busPanel.Tag;

            using (SeatSelectionForm seatForm = new SeatSelectionForm(selectedBus))
            {
                this.Hide();
                seatForm.ShowDialog();
            }
        }

        private void SortBuses(int sortOption)
        {
            this.SuspendLayout();
            int yPos = 180;

            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is Panel p && p.Tag is Bus)
                    this.Controls.RemoveAt(i);
            }

            switch (sortOption)
            {
                case 0:
                    buses.Sort((a, b) => DateTime.Parse(a.DepartureTime).CompareTo(DateTime.Parse(b.DepartureTime)));
                    break;
                case 1:
                    buses.Sort((a, b) => a.Price.CompareTo(b.Price));
                    break;
                case 2:
                    buses.Sort((a, b) => b.Price.CompareTo(a.Price));
                    break;
                case 3:
                    buses.Sort((a, b) =>
                        (DateTime.Parse(a.ArrivalTime) - DateTime.Parse(a.DepartureTime)).CompareTo(
                        DateTime.Parse(b.ArrivalTime) - DateTime.Parse(b.DepartureTime)));
                    break;
            }

            foreach (var bus in buses)
            {
                yPos = AddBusCard(bus, yPos);
            }

            this.ResumeLayout();
        }

        private void AddBackButton(int yPos)
        {
            Button btnBack = new Button
            {
                Text = "← Back to Search",
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(134, 10, 121),
                ForeColor = Color.White,
                Size = new Size(150, 40),
                Location = new Point(30, yPos)
            };
            btnBack.Click += (s, e) => { this.Close(); };
            this.Controls.Add(btnBack);
        }
    }

   
}
