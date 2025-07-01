#nullable disable
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace TicketMate
{
    public partial class PrintTicketForm : Form
    {
        public PrintTicketForm()
        {
            InitializeComponent();
            ShowTicketDetails();
        }

        private void ShowTicketDetails()
        {
            labelPassengerName.Text = "Passenger Name: Ali Haider";
            labelBusName.Text = "Bus: Daewoo Express";
            labelFrom.Text = "From: Islamabad";
            labelTo.Text = "To: Lahore";
            labelSeatNo.Text = "Seat No: 12";
            labelBoarding.Text = "Boarding: G-9 Terminal";
            labelDropping.Text = "Dropping: Lahore City Terminal";
            labelBookingDate.Text = "Booking Date: " + DateTime.Now.ToString("dd-MMM-yyyy");
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket downloaded successfully! (Simple print or screenshot)", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
