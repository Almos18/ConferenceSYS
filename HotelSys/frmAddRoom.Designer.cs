namespace ConferenceSYS_Prototype
{
    partial class frmAddRoom
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
            this.txtRoomNo = new System.Windows.Forms.TextBox();
            this.lblAddRoom = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblRoomCap = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomCapacity = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.btnRoomAdd = new System.Windows.Forms.Button();
            this.grpRoom = new System.Windows.Forms.GroupBox();
            this.grpRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.Location = new System.Drawing.Point(412, 94);
            this.txtRoomNo.MaxLength = 3;
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(174, 26);
            this.txtRoomNo.TabIndex = 5;
            this.txtRoomNo.TextChanged += new System.EventHandler(this.txtRoomNo_TextChanged);
            // 
            // lblAddRoom
            // 
            this.lblAddRoom.AutoSize = true;
            this.lblAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblAddRoom.Location = new System.Drawing.Point(16, 28);
            this.lblAddRoom.Name = "lblAddRoom";
            this.lblAddRoom.Size = new System.Drawing.Size(0, 46);
            this.lblAddRoom.TabIndex = 6;
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(412, 146);
            this.cboRoomType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(174, 28);
            this.cboRoomType.TabIndex = 9;
            this.cboRoomType.SelectedIndexChanged += new System.EventHandler(this.cboRoomType_SelectedIndexChanged);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(9, 91);
            this.lblRoomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(188, 30);
            this.lblRoomNo.TabIndex = 15;
            this.lblRoomNo.Text = "Room Number:";
            // 
            // lblRoomCap
            // 
            this.lblRoomCap.AutoSize = true;
            this.lblRoomCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomCap.Location = new System.Drawing.Point(9, 203);
            this.lblRoomCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomCap.Name = "lblRoomCap";
            this.lblRoomCap.Size = new System.Drawing.Size(120, 30);
            this.lblRoomCap.TabIndex = 16;
            this.lblRoomCap.Text = "Capacity:";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(9, 258);
            this.lblRoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(165, 30);
            this.lblRoomName.TabIndex = 17;
            this.lblRoomName.Text = "Room Name:";
            this.lblRoomName.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(9, 146);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(153, 30);
            this.lblRoomType.TabIndex = 18;
            this.lblRoomType.Text = "Room Type:";
            // 
            // txtRoomCapacity
            // 
            this.txtRoomCapacity.Location = new System.Drawing.Point(412, 206);
            this.txtRoomCapacity.MaxLength = 3;
            this.txtRoomCapacity.Name = "txtRoomCapacity";
            this.txtRoomCapacity.Size = new System.Drawing.Size(174, 26);
            this.txtRoomCapacity.TabIndex = 19;
            this.txtRoomCapacity.TextChanged += new System.EventHandler(this.txtRoomCapacity_TextChanged);
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(412, 262);
            this.txtRoomName.MaxLength = 80;
            this.txtRoomName.Multiline = true;
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(350, 29);
            this.txtRoomName.TabIndex = 20;
            this.txtRoomName.TextChanged += new System.EventHandler(this.txtRoomName_TextChanged);
            // 
            // btnRoomAdd
            // 
            this.btnRoomAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomAdd.Location = new System.Drawing.Point(412, 406);
            this.btnRoomAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRoomAdd.Name = "btnRoomAdd";
            this.btnRoomAdd.Size = new System.Drawing.Size(176, 65);
            this.btnRoomAdd.TabIndex = 21;
            this.btnRoomAdd.Text = "Add Room";
            this.btnRoomAdd.UseVisualStyleBackColor = true;
            this.btnRoomAdd.Click += new System.EventHandler(this.Validate_Click);
            // 
            // grpRoom
            // 
            this.grpRoom.Controls.Add(this.lblRoomNo);
            this.grpRoom.Controls.Add(this.btnRoomAdd);
            this.grpRoom.Controls.Add(this.txtRoomNo);
            this.grpRoom.Controls.Add(this.txtRoomName);
            this.grpRoom.Controls.Add(this.cboRoomType);
            this.grpRoom.Controls.Add(this.txtRoomCapacity);
            this.grpRoom.Controls.Add(this.lblRoomCap);
            this.grpRoom.Controls.Add(this.lblRoomType);
            this.grpRoom.Controls.Add(this.lblRoomName);
            this.grpRoom.Location = new System.Drawing.Point(66, 82);
            this.grpRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRoom.Name = "grpRoom";
            this.grpRoom.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpRoom.Size = new System.Drawing.Size(792, 534);
            this.grpRoom.TabIndex = 22;
            this.grpRoom.TabStop = false;
            this.grpRoom.Text = "Enter Room Details";
            this.grpRoom.Enter += new System.EventHandler(this.grpRoom_Enter);
            // 
            // frmAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 769);
            this.Controls.Add(this.grpRoom);
            this.Controls.Add(this.lblAddRoom);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddRoom";
            this.Text = "Add Room";
            this.Load += new System.EventHandler(this.FrmRoomAdd_Load);
            this.grpRoom.ResumeLayout(false);
            this.grpRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRoomNo;
        private System.Windows.Forms.Label lblAddRoom;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblRoomCap;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtRoomCapacity;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Button btnRoomAdd;
        private System.Windows.Forms.GroupBox grpRoom;
    }
}