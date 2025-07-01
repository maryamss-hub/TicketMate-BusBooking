namespace TicketMate
{
    partial class BusSearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Labels
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelDate;

        // Panels + TextBoxes
        private System.Windows.Forms.Panel panelDeparture;
        private System.Windows.Forms.TextBox textDeparture;
        private System.Windows.Forms.Panel panelDestination;
        private System.Windows.Forms.TextBox textDestination;

        // Date picker
        private System.Windows.Forms.DateTimePicker datePicker;

        // Buttons
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.LinkLabel linkBack;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new System.Windows.Forms.Label();
            labelSubtitle = new System.Windows.Forms.Label();
            labelDeparture = new System.Windows.Forms.Label();
            labelDestination = new System.Windows.Forms.Label();
            labelDate = new System.Windows.Forms.Label();
            panelDeparture = new System.Windows.Forms.Panel();
            textDeparture = new System.Windows.Forms.TextBox();
            panelDestination = new System.Windows.Forms.Panel();
            textDestination = new System.Windows.Forms.TextBox();
            datePicker = new System.Windows.Forms.DateTimePicker();
            buttonSearch = new System.Windows.Forms.Button();
            linkBack = new System.Windows.Forms.LinkLabel();
            panelDeparture.SuspendLayout();
            panelDestination.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = System.Drawing.Color.Transparent;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.FromArgb(125, 25, 112);
            labelTitle.Location = new System.Drawing.Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(207, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Find Buses";
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(159, 86, 158);
            labelSubtitle.Location = new System.Drawing.Point(0, 0);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new System.Drawing.Size(237, 28);
            labelSubtitle.TabIndex = 1;
            labelSubtitle.Text = "Search for available buses";
            // 
            // labelDeparture
            // 
            labelDeparture.AutoSize = true;
            labelDeparture.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelDeparture.ForeColor = System.Drawing.Color.FromArgb(0, 30, 57);
            labelDeparture.Location = new System.Drawing.Point(0, 0);
            labelDeparture.Name = "labelDeparture";
            labelDeparture.Size = new System.Drawing.Size(86, 23);
            labelDeparture.TabIndex = 2;
            labelDeparture.Text = "Departure";
            // 
            // labelDestination
            // 
            labelDestination.AutoSize = true;
            labelDestination.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelDestination.ForeColor = System.Drawing.Color.FromArgb(0, 30, 57);
            labelDestination.Location = new System.Drawing.Point(0, 0);
            labelDestination.Name = "labelDestination";
            labelDestination.Size = new System.Drawing.Size(95, 23);
            labelDestination.TabIndex = 4;
            labelDestination.Text = "Destination";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelDate.ForeColor = System.Drawing.Color.FromArgb(0, 30, 57);
            labelDate.Location = new System.Drawing.Point(0, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(123, 23);
            labelDate.TabIndex = 6;
            labelDate.Text = "Departure Date";
            // 
            // panelDeparture
            // 
            panelDeparture.BackColor = System.Drawing.Color.White;
            panelDeparture.Controls.Add(textDeparture);
            panelDeparture.Location = new System.Drawing.Point(0, 0);
            panelDeparture.Name = "panelDeparture";
            panelDeparture.Size = new System.Drawing.Size(200, 100);
            panelDeparture.TabIndex = 3;
            panelDeparture.Paint += panelDeparture_Paint;
            // 
            // textDeparture
            // 
            textDeparture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textDeparture.Font = new System.Drawing.Font("Segoe UI", 14F);
            textDeparture.ForeColor = System.Drawing.Color.FromArgb(191, 191, 191);
            textDeparture.Location = new System.Drawing.Point(0, 0);
            textDeparture.Name = "textDeparture";
            textDeparture.Size = new System.Drawing.Size(100, 32);
            textDeparture.TabIndex = 0;
            textDeparture.Text = "From";
            // 
            // panelDestination
            // 
            panelDestination.BackColor = System.Drawing.Color.White;
            panelDestination.Controls.Add(textDestination);
            panelDestination.Location = new System.Drawing.Point(0, 0);
            panelDestination.Name = "panelDestination";
            panelDestination.Size = new System.Drawing.Size(200, 100);
            panelDestination.TabIndex = 5;
            panelDestination.Paint += panelDestination_Paint;
            // 
            // textDestination
            // 
            textDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textDestination.Font = new System.Drawing.Font("Segoe UI", 14F);
            textDestination.ForeColor = System.Drawing.Color.FromArgb(191, 191, 191);
            textDestination.Location = new System.Drawing.Point(0, 0);
            textDestination.Name = "textDestination";
            textDestination.Size = new System.Drawing.Size(100, 32);
            textDestination.TabIndex = 0;
            textDestination.Text = "To";
            // 
            // datePicker
            // 
            datePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 14F);
            datePicker.CalendarForeColor = System.Drawing.Color.FromArgb(0, 30, 57);
            datePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(134, 10, 121);
            datePicker.CalendarTitleForeColor = System.Drawing.Color.White;
            datePicker.Font = new System.Drawing.Font("Segoe UI", 14F);
            datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            datePicker.Location = new System.Drawing.Point(0, 0);
            datePicker.Name = "datePicker";
            datePicker.Size = new System.Drawing.Size(200, 39);
            datePicker.TabIndex = 7;
            // 
            // buttonSearch
            // 
            buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            buttonSearch.BackColor = System.Drawing.Color.FromArgb(134, 10, 121);
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSearch.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            buttonSearch.ForeColor = System.Drawing.Color.White;
            buttonSearch.Location = new System.Drawing.Point(0, 0);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(75, 23);
            buttonSearch.TabIndex = 8;
            buttonSearch.Text = "Search Buses";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // linkBack
            // 
            linkBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            linkBack.LinkColor = System.Drawing.Color.FromArgb(146, 55, 120);
            linkBack.Location = new System.Drawing.Point(0, 0);
            linkBack.Name = "linkBack";
            linkBack.Size = new System.Drawing.Size(100, 23);
            linkBack.TabIndex = 9;
            linkBack.TabStop = true;
            linkBack.Text = "← Back";
            // 
            // BusSearchForm
            // 
            AcceptButton = buttonSearch;
            ClientSize = new System.Drawing.Size(414, 736);
            Controls.Add(labelTitle);
            Controls.Add(labelSubtitle);
            Controls.Add(labelDeparture);
            Controls.Add(panelDeparture);
            Controls.Add(labelDestination);
            Controls.Add(panelDestination);
            Controls.Add(labelDate);
            Controls.Add(datePicker);
            Controls.Add(buttonSearch);
            Controls.Add(linkBack);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BusSearchForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Find Buses";
            Load += BusSearchForm_Load;
            Paint += BusSearchForm_Paint;
            panelDeparture.ResumeLayout(false);
            panelDeparture.PerformLayout();
            panelDestination.ResumeLayout(false);
            panelDestination.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        // ========== Paint: pink gradient background ==========
        private void BusSearchForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                System.Drawing.ColorTranslator.FromHtml("#FEEEF0"),  // top
                System.Drawing.ColorTranslator.FromHtml("#F8F8F8"),  // bottom
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        // ========== Load: layout + rounding ==========
        private void BusSearchForm_Load(object sender, System.EventArgs e)
        {
            PerformLayoutCustom();

            // Round corners for panels and button
            RoundControlCorners(panelDeparture, 16);
            RoundControlCorners(panelDestination, 16);
            RoundControlCorners(buttonSearch, 30);   // half of ~50–60 height

            // Set minimum date to today
            datePicker.MinDate = System.DateTime.Today;
            datePicker.Value = System.DateTime.Today;

            // Set up placeholder behavior for text boxes
            SetupPlaceholder(textDeparture, "From");
            SetupPlaceholder(textDestination, "To");
        }

        // ========== Setup placeholder text behavior ==========
        private void SetupPlaceholder(System.Windows.Forms.TextBox textBox, string placeholder)
        {
            // Set initial state
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.FromArgb(191, 191, 191);

            // Handle focus events
            textBox.GotFocus += (s, e) => {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = string.Empty;
                    textBox.ForeColor = System.Drawing.Color.FromArgb(0, 30, 57);
                }
            };

            textBox.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.FromArgb(191, 191, 191);
                }
            };
        }

        // ========== Manual layout method ==========
        private void PerformLayoutCustom()
        {
            int formWidth = this.ClientSize.Width; // 414
            int xCenter = formWidth / 2;
            int currentY = 30;

            // Back link (top left)
            linkBack.Left = 20;
            linkBack.Top = currentY;
            linkBack.Width = 60;
            currentY += linkBack.Height + 10;

            // Title: center horizontally
            labelTitle.Left = xCenter - (labelTitle.Width / 2);
            labelTitle.Top = currentY;
            currentY += labelTitle.Height + 5;

            // Subtitle: center horizontally
            labelSubtitle.Left = xCenter - (labelSubtitle.Width / 2);
            labelSubtitle.Top = currentY;
            currentY += labelSubtitle.Height + 30;

            // labelDeparture
            labelDeparture.Left = 50;
            labelDeparture.Top = currentY;
            currentY += labelDeparture.Height + 5;

            // panelDeparture
            panelDeparture.Left = 50;
            panelDeparture.Top = currentY;
            panelDeparture.Width = 314;  // 414 - 2*50 = 314
            panelDeparture.Height = 44;
            textDeparture.Left = 10;
            textDeparture.Top = 8;
            textDeparture.Width = panelDeparture.Width - 20;
            currentY += panelDeparture.Height + 20;

            // labelDestination
            labelDestination.Left = 50;
            labelDestination.Top = currentY;
            currentY += labelDestination.Height + 5;

            // panelDestination
            panelDestination.Left = 50;
            panelDestination.Top = currentY;
            panelDestination.Width = 314;
            panelDestination.Height = 44;
            textDestination.Left = 10;
            textDestination.Top = 8;
            textDestination.Width = panelDestination.Width - 20;
            currentY += panelDestination.Height + 20;

            // labelDate
            labelDate.Left = 50;
            labelDate.Top = currentY;
            currentY += labelDate.Height + 5;

            // DateTimePicker
            datePicker.Left = 50;
            datePicker.Top = currentY;
            datePicker.Width = 314;
            datePicker.Height = 44;
            currentY += datePicker.Height + 40;

            // buttonSearch
            buttonSearch.Left = 50;
            buttonSearch.Top = currentY;
            buttonSearch.Width = 314;
            buttonSearch.Height = 48;
        }

        // ========== panelDeparture Paint (1px border) ==========
        private void panelDeparture_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // e.g., 1px solid ~rgba(211,0,176,0.3)
            using (var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(77, 211, 0, 176), 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0, 0,
                    panelDeparture.Width - 1,
                    panelDeparture.Height - 1);
            }
        }

        // ========== panelDestination Paint (1px border) ==========
        private void panelDestination_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // e.g., 1px solid ~rgba(156,70,152,0.3)
            using (var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(77, 156, 70, 152), 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0, 0,
                    panelDestination.Width - 1,
                    panelDestination.Height - 1);
            }
        }

        // ========== Helper: round corners ==========
        private void RoundControlCorners(System.Windows.Forms.Control ctrl, int radius)
        {
            if (ctrl.Width < 1 || ctrl.Height < 1) return;

            System.Drawing.Rectangle bounds = new System.Drawing.Rectangle(0, 0, ctrl.Width, ctrl.Height);
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int diameter = radius * 2;
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                ctrl.Region = new System.Drawing.Region(path);
            }
        }
    }
}