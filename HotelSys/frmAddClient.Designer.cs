namespace ConferenceSYS_Prototype
{
    partial class frmAddClient
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.grpClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(418, 128);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(172, 26);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblFirstName.Location = new System.Drawing.Point(32, 128);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(147, 30);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(418, 309);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(304, 26);
            this.txtPhone.TabIndex = 6;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblLastName.Location = new System.Drawing.Point(32, 185);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(144, 30);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(418, 185);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(172, 26);
            this.txtLastName.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblEmail.Location = new System.Drawing.Point(32, 246);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(158, 30);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Client Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblPhone.Location = new System.Drawing.Point(32, 306);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(140, 30);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Telephone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(418, 246);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 26);
            this.txtEmail.TabIndex = 12;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(418, 431);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(174, 69);
            this.btnAddClient.TabIndex = 22;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.Validate_Click);
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.lblClientId);
            this.grpClient.Controls.Add(this.txtClientId);
            this.grpClient.Controls.Add(this.lblFirstName);
            this.grpClient.Controls.Add(this.btnAddClient);
            this.grpClient.Controls.Add(this.txtFirstName);
            this.grpClient.Controls.Add(this.txtEmail);
            this.grpClient.Controls.Add(this.txtPhone);
            this.grpClient.Controls.Add(this.lblPhone);
            this.grpClient.Controls.Add(this.lblLastName);
            this.grpClient.Controls.Add(this.lblEmail);
            this.grpClient.Controls.Add(this.txtLastName);
            this.grpClient.Location = new System.Drawing.Point(108, 117);
            this.grpClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpClient.Name = "grpClient";
            this.grpClient.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpClient.Size = new System.Drawing.Size(966, 563);
            this.grpClient.TabIndex = 23;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Enter Client Details";
            // 
            // lblClientId
            // 
            this.lblClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientId.Location = new System.Drawing.Point(33, 63);
            this.lblClientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(150, 31);
            this.lblClientId.TabIndex = 24;
            this.lblClientId.Text = "Client ID:";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(418, 58);
            this.txtClientId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(172, 26);
            this.txtClientId.TabIndex = 23;
            this.txtClientId.TextChanged += new System.EventHandler(this.txtClientId_TextChanged);
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 791);
            this.Controls.Add(this.grpClient);
            this.Name = "frmAddClient";
            this.Text = "Add Client";
            this.Load += new System.EventHandler(this.frmAddClient_Load);
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtClientId;
    }
}