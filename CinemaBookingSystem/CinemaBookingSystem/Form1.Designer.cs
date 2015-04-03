namespace CinemaBookingSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rbtnCancel = new System.Windows.Forms.RadioButton();
            this.rbtnReserve = new System.Windows.Forms.RadioButton();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            this.txtNumOfVacant = new System.Windows.Forms.TextBox();
            this.txtNumOfReservedSeats = new System.Windows.Forms.TextBox();
            this.txtNumOfSeats = new System.Windows.Forms.TextBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblNumOfVacant = new System.Windows.Forms.Label();
            this.lblNumOfReservedSeats = new System.Windows.Forms.Label();
            this.lblNumOfSeats = new System.Windows.Forms.Label();
            this.grpReservations = new System.Windows.Forms.GroupBox();
            this.lblPriceReserv = new System.Windows.Forms.Label();
            this.lblNameReserv = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpReservations.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnOK);
            this.grpInput.Controls.Add(this.txtPrice);
            this.grpInput.Controls.Add(this.txtName);
            this.grpInput.Controls.Add(this.lblPrice);
            this.grpInput.Controls.Add(this.lblName);
            this.grpInput.Controls.Add(this.rbtnCancel);
            this.grpInput.Controls.Add(this.rbtnReserve);
            this.grpInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(200, 127);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Booking input";
            // 
            // btnOK
            // 
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(51, 93);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Reserv / Cancel";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(154, 66);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(40, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(7, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(153, 50);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(6, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbtnCancel
            // 
            this.rbtnCancel.AutoSize = true;
            this.rbtnCancel.ForeColor = System.Drawing.Color.Black;
            this.rbtnCancel.Location = new System.Drawing.Point(95, 20);
            this.rbtnCancel.Name = "rbtnCancel";
            this.rbtnCancel.Size = new System.Drawing.Size(89, 17);
            this.rbtnCancel.TabIndex = 0;
            this.rbtnCancel.TabStop = true;
            this.rbtnCancel.Text = "Cancel Resv.";
            this.rbtnCancel.UseVisualStyleBackColor = true;
            // 
            // rbtnReserve
            // 
            this.rbtnReserve.AutoSize = true;
            this.rbtnReserve.Checked = true;
            this.rbtnReserve.ForeColor = System.Drawing.Color.Black;
            this.rbtnReserve.Location = new System.Drawing.Point(7, 20);
            this.rbtnReserve.Name = "rbtnReserve";
            this.rbtnReserve.Size = new System.Drawing.Size(65, 17);
            this.rbtnReserve.TabIndex = 0;
            this.rbtnReserve.TabStop = true;
            this.rbtnReserve.Text = "Reserve";
            this.rbtnReserve.UseVisualStyleBackColor = true;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.txtTotalRevenue);
            this.grpOutput.Controls.Add(this.txtNumOfVacant);
            this.grpOutput.Controls.Add(this.txtNumOfReservedSeats);
            this.grpOutput.Controls.Add(this.txtNumOfSeats);
            this.grpOutput.Controls.Add(this.lblTotalRevenue);
            this.grpOutput.Controls.Add(this.lblNumOfVacant);
            this.grpOutput.Controls.Add(this.lblNumOfReservedSeats);
            this.grpOutput.Controls.Add(this.lblNumOfSeats);
            this.grpOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grpOutput.Location = new System.Drawing.Point(12, 159);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(200, 149);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output Data";
            this.grpOutput.Enter += new System.EventHandler(this.grpOutput_Enter);
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Enabled = false;
            this.txtTotalRevenue.Location = new System.Drawing.Point(131, 108);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.Size = new System.Drawing.Size(63, 20);
            this.txtTotalRevenue.TabIndex = 2;
            // 
            // txtNumOfVacant
            // 
            this.txtNumOfVacant.Enabled = false;
            this.txtNumOfVacant.Location = new System.Drawing.Point(131, 82);
            this.txtNumOfVacant.Name = "txtNumOfVacant";
            this.txtNumOfVacant.Size = new System.Drawing.Size(63, 20);
            this.txtNumOfVacant.TabIndex = 2;
            // 
            // txtNumOfReservedSeats
            // 
            this.txtNumOfReservedSeats.Enabled = false;
            this.txtNumOfReservedSeats.Location = new System.Drawing.Point(131, 53);
            this.txtNumOfReservedSeats.Name = "txtNumOfReservedSeats";
            this.txtNumOfReservedSeats.Size = new System.Drawing.Size(63, 20);
            this.txtNumOfReservedSeats.TabIndex = 2;
            // 
            // txtNumOfSeats
            // 
            this.txtNumOfSeats.Enabled = false;
            this.txtNumOfSeats.Location = new System.Drawing.Point(130, 23);
            this.txtNumOfSeats.Name = "txtNumOfSeats";
            this.txtNumOfSeats.Size = new System.Drawing.Size(63, 20);
            this.txtNumOfSeats.TabIndex = 2;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRevenue.Location = new System.Drawing.Point(6, 118);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(81, 13);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "Total Revenue:";
            this.lblTotalRevenue.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumOfVacant
            // 
            this.lblNumOfVacant.AutoSize = true;
            this.lblNumOfVacant.ForeColor = System.Drawing.Color.Black;
            this.lblNumOfVacant.Location = new System.Drawing.Point(6, 89);
            this.lblNumOfVacant.Name = "lblNumOfVacant";
            this.lblNumOfVacant.Size = new System.Drawing.Size(96, 13);
            this.lblNumOfVacant.TabIndex = 1;
            this.lblNumOfVacant.Text = "Number of Vacant:";
            this.lblNumOfVacant.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumOfReservedSeats
            // 
            this.lblNumOfReservedSeats.AutoSize = true;
            this.lblNumOfReservedSeats.ForeColor = System.Drawing.Color.Black;
            this.lblNumOfReservedSeats.Location = new System.Drawing.Point(6, 60);
            this.lblNumOfReservedSeats.Name = "lblNumOfReservedSeats";
            this.lblNumOfReservedSeats.Size = new System.Drawing.Size(108, 13);
            this.lblNumOfReservedSeats.TabIndex = 1;
            this.lblNumOfReservedSeats.Text = "Number of Reserved:";
            this.lblNumOfReservedSeats.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNumOfSeats
            // 
            this.lblNumOfSeats.AutoSize = true;
            this.lblNumOfSeats.ForeColor = System.Drawing.Color.Black;
            this.lblNumOfSeats.Location = new System.Drawing.Point(6, 26);
            this.lblNumOfSeats.Name = "lblNumOfSeats";
            this.lblNumOfSeats.Size = new System.Drawing.Size(89, 13);
            this.lblNumOfSeats.TabIndex = 1;
            this.lblNumOfSeats.Text = "Number of Seats:";
            this.lblNumOfSeats.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpReservations
            // 
            this.grpReservations.Controls.Add(this.lstReservations);
            this.grpReservations.Controls.Add(this.lblPriceReserv);
            this.grpReservations.Controls.Add(this.lblNameReserv);
            this.grpReservations.Controls.Add(this.lblStatus);
            this.grpReservations.Controls.Add(this.lblSeat);
            this.grpReservations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grpReservations.Location = new System.Drawing.Point(232, 12);
            this.grpReservations.Name = "grpReservations";
            this.grpReservations.Size = new System.Drawing.Size(453, 296);
            this.grpReservations.TabIndex = 2;
            this.grpReservations.TabStop = false;
            this.grpReservations.Text = "Reservations";
            // 
            // lblPriceReserv
            // 
            this.lblPriceReserv.AutoSize = true;
            this.lblPriceReserv.ForeColor = System.Drawing.Color.Black;
            this.lblPriceReserv.Location = new System.Drawing.Point(355, 34);
            this.lblPriceReserv.Name = "lblPriceReserv";
            this.lblPriceReserv.Size = new System.Drawing.Size(31, 13);
            this.lblPriceReserv.TabIndex = 1;
            this.lblPriceReserv.Text = "Price";
            this.lblPriceReserv.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNameReserv
            // 
            this.lblNameReserv.AutoSize = true;
            this.lblNameReserv.ForeColor = System.Drawing.Color.Black;
            this.lblNameReserv.Location = new System.Drawing.Point(189, 34);
            this.lblNameReserv.Name = "lblNameReserv";
            this.lblNameReserv.Size = new System.Drawing.Size(35, 13);
            this.lblNameReserv.TabIndex = 1;
            this.lblNameReserv.Text = "Name";
            this.lblNameReserv.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(98, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.ForeColor = System.Drawing.Color.Black;
            this.lblSeat.Location = new System.Drawing.Point(26, 34);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(29, 13);
            this.lblSeat.TabIndex = 1;
            this.lblSeat.Text = "Seat";
            this.lblSeat.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstReservations
            // 
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.Location = new System.Drawing.Point(16, 66);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(417, 199);
            this.lstReservations.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 329);
            this.Controls.Add(this.grpReservations);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Name = "Form1";
            this.Text = "CBC Cinema Booking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpReservations.ResumeLayout(false);
            this.grpReservations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.RadioButton rbtnReserve;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbtnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtNumOfSeats;
        private System.Windows.Forms.Label lblNumOfSeats;
        private System.Windows.Forms.Label lblNumOfReservedSeats;
        private System.Windows.Forms.TextBox txtNumOfReservedSeats;
        private System.Windows.Forms.TextBox txtTotalRevenue;
        private System.Windows.Forms.TextBox txtNumOfVacant;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblNumOfVacant;
        private System.Windows.Forms.GroupBox grpReservations;
        private System.Windows.Forms.Label lblPriceReserv;
        private System.Windows.Forms.Label lblNameReserv;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.ListBox lstReservations;

    }
}

