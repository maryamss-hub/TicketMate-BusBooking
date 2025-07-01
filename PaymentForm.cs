#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicketMate
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            if (!radioCard.Checked && !radioCash.Checked)
            {
                MessageBox.Show("Please select a payment method!");
                return;
            }

            if (radioCard.Checked)
            {
                MessageBox.Show("Online Payment Successful!");
            }
            else if (radioCash.Checked)
            {
                MessageBox.Show("You selected to Pay Cash at Terminal.");
            }

            PrintTicketForm ticketForm = new PrintTicketForm();
            ticketForm.Show();
            this.Hide();
        }
    }
}
