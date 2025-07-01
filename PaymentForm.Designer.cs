#nullable disable
namespace TicketMate
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.radioCard = new System.Windows.Forms.RadioButton();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.buttonProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaymentForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 736);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.ResumeLayout(false);

            // Title
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTitle.Text = "Choose Payment Method";
            this.labelTitle.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(138, 34, 111);
            this.labelTitle.Location = new System.Drawing.Point(30, 30);
            this.labelTitle.AutoSize = true;
            this.Controls.Add(this.labelTitle);

            // Radio Card
            this.radioCard = new System.Windows.Forms.RadioButton();
            this.radioCard.Text = "Pay by Card";
            this.radioCard.Font = new System.Drawing.Font("Inter", 12F);
            this.radioCard.Location = new System.Drawing.Point(30, 100);
            this.radioCard.AutoSize = true;
            this.Controls.Add(this.radioCard);

            // Radio Cash
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioCash.Text = "Pay Cash at Terminal";
            this.radioCash.Font = new System.Drawing.Font("Inter", 12F);
            this.radioCash.Location = new System.Drawing.Point(30, 150);
            this.radioCash.AutoSize = true;
            this.Controls.Add(this.radioCash);

            // Button Proceed
            this.buttonProceed = new System.Windows.Forms.Button();
            this.buttonProceed.Text = "Proceed";
            this.buttonProceed.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.buttonProceed.Size = new System.Drawing.Size(340, 40);
            this.buttonProceed.Location = new System.Drawing.Point(30, 250);
            this.buttonProceed.BackColor = System.Drawing.Color.FromArgb(138, 34, 111);
            this.buttonProceed.ForeColor = System.Drawing.Color.White;
            this.buttonProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProceed.Click += new System.EventHandler(this.buttonProceed_Click);
            this.Controls.Add(this.buttonProceed);
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radioCard;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.Button buttonProceed;

        #endregion
    }
}
