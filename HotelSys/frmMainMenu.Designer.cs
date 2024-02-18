namespace ConferenceSYS_Prototype
{
    partial class frmMainMenu
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.stpRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.itmAddRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.itmDeleteRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.stpClient = new System.Windows.Forms.ToolStripMenuItem();
            this.itmAddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.itmUpdateClient = new System.Windows.Forms.ToolStripMenuItem();
            this.stpBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.itmResRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.ismDeleteRes = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.stpRoom,
            this.stpClient,
            this.stpBooking});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.mnuMain.Size = new System.Drawing.Size(1036, 35);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "mnuMain";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(55, 29);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stpRoom
            // 
            this.stpRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmAddRoom,
            this.itmDeleteRoom});
            this.stpRoom.Name = "stpRoom";
            this.stpRoom.Size = new System.Drawing.Size(157, 29);
            this.stpRoom.Text = "Room Functions";
            // 
            // itmAddRoom
            // 
            this.itmAddRoom.Name = "itmAddRoom";
            this.itmAddRoom.Size = new System.Drawing.Size(217, 34);
            this.itmAddRoom.Text = "Add Room";
            this.itmAddRoom.Click += new System.EventHandler(this.addRoomToolStripMenuItem_Click);
            // 
            // itmDeleteRoom
            // 
            this.itmDeleteRoom.Name = "itmDeleteRoom";
            this.itmDeleteRoom.Size = new System.Drawing.Size(217, 34);
            this.itmDeleteRoom.Text = "Delete Room";
            this.itmDeleteRoom.Click += new System.EventHandler(this.deleteRoomToolStripMenuItem_Click);
            // 
            // stpClient
            // 
            this.stpClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmAddClient,
            this.itmUpdateClient});
            this.stpClient.Name = "stpClient";
            this.stpClient.Size = new System.Drawing.Size(153, 29);
            this.stpClient.Text = "Client Functions";
            // 
            // itmAddClient
            // 
            this.itmAddClient.Name = "itmAddClient";
            this.itmAddClient.Size = new System.Drawing.Size(221, 34);
            this.itmAddClient.Text = "Add Client";
            this.itmAddClient.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // itmUpdateClient
            // 
            this.itmUpdateClient.Name = "itmUpdateClient";
            this.itmUpdateClient.Size = new System.Drawing.Size(221, 34);
            this.itmUpdateClient.Text = "Update Client";
            this.itmUpdateClient.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // stpBooking
            // 
            this.stpBooking.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itmResRoom,
            this.ismDeleteRes});
            this.stpBooking.Name = "stpBooking";
            this.stpBooking.Size = new System.Drawing.Size(175, 29);
            this.stpBooking.Text = "Booking Functions";
            // 
            // itmResRoom
            // 
            this.itmResRoom.Name = "itmResRoom";
            this.itmResRoom.Size = new System.Drawing.Size(270, 34);
            this.itmResRoom.Text = "Reserve Room";
            this.itmResRoom.Click += new System.EventHandler(this.bookRoomToolStripMenuItem_Click);
            // 
            // ismDeleteRes
            // 
            this.ismDeleteRes.Name = "ismDeleteRes";
            this.ismDeleteRes.Size = new System.Drawing.Size(270, 34);
            this.ismDeleteRes.Text = "Delete Reservation";
            this.ismDeleteRes.Click += new System.EventHandler(this.deleteReservationToolStripMenuItem_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(164, 103);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(685, 58);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome to ConferenceSYS";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.Location = new System.Drawing.Point(280, 163);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(398, 30);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Please select what you want to do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 331);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem stpRoom;
        private System.Windows.Forms.ToolStripMenuItem itmAddRoom;
        private System.Windows.Forms.ToolStripMenuItem itmDeleteRoom;
        private System.Windows.Forms.ToolStripMenuItem stpClient;
        private System.Windows.Forms.ToolStripMenuItem itmAddClient;
        private System.Windows.Forms.ToolStripMenuItem itmUpdateClient;
        private System.Windows.Forms.ToolStripMenuItem stpBooking;
        private System.Windows.Forms.ToolStripMenuItem itmResRoom;
        private System.Windows.Forms.ToolStripMenuItem ismDeleteRes;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label label3;
    }
}

