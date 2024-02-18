namespace ConferenceSYS_Prototype
{
    partial class frmDeleteRes
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
            this.cboReservations = new System.Windows.Forms.ComboBox();
            this.btnDeleteRes = new System.Windows.Forms.Button();
            this.lblBookingId = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboReservations
            // 
            this.cboReservations.FormattingEnabled = true;
            this.cboReservations.Location = new System.Drawing.Point(275, 226);
            this.cboReservations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboReservations.Name = "cboReservations";
            this.cboReservations.Size = new System.Drawing.Size(406, 28);
            this.cboReservations.TabIndex = 29;
            this.cboReservations.SelectedIndexChanged += new System.EventHandler(this.cboReservations_SelectedIndexChanged);
            // 
            // btnDeleteRes
            // 
            this.btnDeleteRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRes.Location = new System.Drawing.Point(473, 348);
            this.btnDeleteRes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteRes.Name = "btnDeleteRes";
            this.btnDeleteRes.Size = new System.Drawing.Size(208, 80);
            this.btnDeleteRes.TabIndex = 28;
            this.btnDeleteRes.Text = "Delete Reservation";
            this.btnDeleteRes.UseVisualStyleBackColor = true;
            this.btnDeleteRes.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingId.Location = new System.Drawing.Point(61, 220);
            this.lblBookingId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(144, 30);
            this.lblBookingId.TabIndex = 26;
            this.lblBookingId.Text = "Booking ID:";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(60, 54);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(459, 36);
            this.lblSelect.TabIndex = 25;
            this.lblSelect.Text = "Select which reservation to delete";
            // 
            // frmDeleteRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 505);
            this.Controls.Add(this.btnDeleteRes);
            this.Controls.Add(this.cboReservations);
            this.Controls.Add(this.lblBookingId);
            this.Controls.Add(this.lblSelect);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDeleteRes";
            this.Text = "Delete Reservation";
            this.Load += new System.EventHandler(this.frmDeleteRes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboReservations;
        public System.Windows.Forms.Button btnDeleteRes;
        private System.Windows.Forms.Label lblBookingId;
        private System.Windows.Forms.Label lblSelect;
    }
}