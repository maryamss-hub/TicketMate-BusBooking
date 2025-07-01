#nullable disable
namespace TicketMate
{
    partial class PrintTicketForm
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
            this.labelPassengerName = new System.Windows.Forms.Label();
            this.labelBusName = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelSeatNo = new System.Windows.Forms.Label();
            this.labelBoarding = new System.Windows.Forms.Label();
            this.labelDropping = new System.Windows.Forms.Label();
            this.labelBookingDate = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrintTicketForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 736);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "PrintTicketForm";
            this.Text = "Print Ticket";
            this.ResumeLayout(false);

            int y = 30;
            int spacing = 40;

            // Title
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTitle.Text = "Ticket Summary";
            this.labelTitle.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(138, 34, 111);
            this.labelTitle.Location = new System.Drawing.Point(30, y);
            this.labelTitle.AutoSize = true;
            this.Controls.Add(this.labelTitle);

            // Fields
            this.labelPassengerName = CreateLabel(30, y += spacing);
            this.labelBusName = CreateLabel(30, y += spacing);
            this.labelFrom = CreateLabel(30, y += spacing);
            this.labelTo = CreateLabel(30, y += spacing);
            this.labelSeatNo = CreateLabel(30, y += spacing);
            this.labelBoarding = CreateLabel(30, y += spacing);
            this.labelDropping = CreateLabel(30, y += spacing);
            this.labelBookingDate = CreateLabel(30, y += spacing);

            this.Controls.Add(this.labelPassengerName);
            this.Controls.Add(this.labelBusName);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelSeatNo);
            this.Controls.Add(this.labelBoarding);
            this.Controls.Add(this.labelDropping);
            this.Controls.Add(this.labelBookingDate);

            // Download button
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonDownload.Text = "Download Ticket";
            this.buttonDownload.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDownload.Size = new System.Drawing.Size(340, 40);
            this.buttonDownload.Location = new System.Drawing.Point(30, y + 50);
            this.buttonDownload.BackColor = System.Drawing.Color.FromArgb(138, 34, 111);
            this.buttonDownload.ForeColor = System.Drawing.Color.White;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            this.Controls.Add(this.buttonDownload);
        }

        private Label CreateLabel(int x, int y)
        {
            return new System.Windows.Forms.Label
            {
                Location = new System.Drawing.Point(x, y),
                Font = new System.Drawing.Font("Inter", 12F),
                AutoSize = true
            };
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPassengerName;
        private System.Windows.Forms.Label labelBusName;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelSeatNo;
        private System.Windows.Forms.Label labelBoarding;
        private System.Windows.Forms.Label labelDropping;
        private System.Windows.Forms.Label labelBookingDate;
        private System.Windows.Forms.Button buttonDownload;

        #endregion
    }
}
