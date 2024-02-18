namespace ConferenceSYS_Prototype
{
    partial class frmReserveRoom
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
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnResRoom = new System.Windows.Forms.Button();
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.cboClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.cboRooms = new System.Windows.Forms.ComboBox();
            this.txtBookingId = new System.Windows.Forms.TextBox();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.dtTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grpBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(43, 174);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(188, 30);
            this.lblRoomNo.TabIndex = 1;
            this.lblRoomNo.Text = "Room Number:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(47, 237);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 30);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(43, 296);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(78, 30);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time:";
            // 
            // btnResRoom
            // 
            this.btnResRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResRoom.Location = new System.Drawing.Point(446, 367);
            this.btnResRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResRoom.Name = "btnResRoom";
            this.btnResRoom.Size = new System.Drawing.Size(189, 83);
            this.btnResRoom.TabIndex = 22;
            this.btnResRoom.Text = "Reserve Room";
            this.btnResRoom.UseVisualStyleBackColor = true;
            this.btnResRoom.Click += new System.EventHandler(this.Validate_Click);
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.cboClient);
            this.grpBooking.Controls.Add(this.lblClient);
            this.grpBooking.Controls.Add(this.cboRooms);
            this.grpBooking.Controls.Add(this.txtBookingId);
            this.grpBooking.Controls.Add(this.lblBookingId);
            this.grpBooking.Controls.Add(this.cboTime);
            this.grpBooking.Controls.Add(this.dtTimePicker);
            this.grpBooking.Controls.Add(this.lblRoomNo);
            this.grpBooking.Controls.Add(this.btnResRoom);
            this.grpBooking.Controls.Add(this.lblDate);
            this.grpBooking.Controls.Add(this.lblTime);
            this.grpBooking.Location = new System.Drawing.Point(38, 60);
            this.grpBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBooking.Size = new System.Drawing.Size(802, 471);
            this.grpBooking.TabIndex = 23;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Enter Booking Details";
            this.grpBooking.Enter += new System.EventHandler(this.grpBooking_Enter);
            // 
            // cboClient
            // 
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(446, 122);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(121, 28);
            this.cboClient.TabIndex = 32;
            this.cboClient.SelectedIndexChanged += new System.EventHandler(this.cboClient_SelectedIndexChanged);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(47, 116);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(118, 30);
            this.lblClient.TabIndex = 31;
            this.lblClient.Text = "Client ID:";
            // 
            // cboRooms
            // 
            this.cboRooms.FormattingEnabled = true;
            this.cboRooms.Location = new System.Drawing.Point(446, 180);
            this.cboRooms.Name = "cboRooms";
            this.cboRooms.Size = new System.Drawing.Size(121, 28);
            this.cboRooms.TabIndex = 29;
            this.cboRooms.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBookingId
            // 
            this.txtBookingId.Location = new System.Drawing.Point(446, 59);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.Size = new System.Drawing.Size(121, 26);
            this.txtBookingId.TabIndex = 28;
            this.txtBookingId.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingId.Location = new System.Drawing.Point(47, 53);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(144, 30);
            this.lblBookingId.TabIndex = 27;
            this.lblBookingId.Text = "Booking ID:";
            // 
            // cboTime
            // 
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Location = new System.Drawing.Point(446, 302);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(121, 28);
            this.cboTime.TabIndex = 26;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // dtTimePicker
            // 
            this.dtTimePicker.Location = new System.Drawing.Point(446, 241);
            this.dtTimePicker.Name = "dtTimePicker";
            this.dtTimePicker.Size = new System.Drawing.Size(285, 26);
            this.dtTimePicker.TabIndex = 25;
            this.dtTimePicker.ValueChanged += new System.EventHandler(this.dtTimePicker_ValueChanged);
            // 
            // frmReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 578);
            this.Controls.Add(this.grpBooking);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReserveRoom";
            this.Text = "Reserve Room";
            this.Load += new System.EventHandler(this.frmReserveRoom_Load);
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnResRoom;
        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.DateTimePicker dtTimePicker;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.TextBox txtBookingId;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.ComboBox cboRooms;
        private System.Windows.Forms.ComboBox cboClient;
        private System.Windows.Forms.Label lblClient;
    }
}