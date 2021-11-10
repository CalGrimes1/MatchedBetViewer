namespace BetBot7
{
    partial class frmSettings
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
            this.lblAccSettings = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLeader = new System.Windows.Forms.Label();
            this.lblStake = new System.Windows.Forms.Label();
            this.lblBasic = new System.Windows.Forms.Label();
            this.lblProxy = new System.Windows.Forms.Label();
            this.lblSocket = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLeader = new System.Windows.Forms.TextBox();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.txtSocket = new System.Windows.Forms.TextBox();
            this.txtStake = new System.Windows.Forms.TextBox();
            this.cBoxFollowLeader = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAccSettings
            // 
            this.lblAccSettings.AutoSize = true;
            this.lblAccSettings.Location = new System.Drawing.Point(21, 22);
            this.lblAccSettings.Name = "lblAccSettings";
            this.lblAccSettings.Size = new System.Drawing.Size(47, 13);
            this.lblAccSettings.TabIndex = 0;
            this.lblAccSettings.Text = "Account";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(46, 56);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(44, 13);
            this.lblLicense.TabIndex = 1;
            this.lblLicense.Text = "License";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(46, 97);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(46, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblLeader
            // 
            this.lblLeader.AutoSize = true;
            this.lblLeader.Location = new System.Drawing.Point(46, 197);
            this.lblLeader.Name = "lblLeader";
            this.lblLeader.Size = new System.Drawing.Size(40, 13);
            this.lblLeader.TabIndex = 4;
            this.lblLeader.Text = "Leader";
            // 
            // lblStake
            // 
            this.lblStake.AutoSize = true;
            this.lblStake.Location = new System.Drawing.Point(46, 249);
            this.lblStake.Name = "lblStake";
            this.lblStake.Size = new System.Drawing.Size(35, 13);
            this.lblStake.TabIndex = 5;
            this.lblStake.Text = "Stake";
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Location = new System.Drawing.Point(21, 337);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(33, 13);
            this.lblBasic.TabIndex = 6;
            this.lblBasic.Text = "Basic";
            // 
            // lblProxy
            // 
            this.lblProxy.AutoSize = true;
            this.lblProxy.Location = new System.Drawing.Point(46, 379);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(61, 13);
            this.lblProxy.TabIndex = 7;
            this.lblProxy.Text = "Proxy URL:";
            // 
            // lblSocket
            // 
            this.lblSocket.AutoSize = true;
            this.lblSocket.Location = new System.Drawing.Point(46, 430);
            this.lblSocket.Name = "lblSocket";
            this.lblSocket.Size = new System.Drawing.Size(69, 13);
            this.lblSocket.TabIndex = 8;
            this.lblSocket.Text = "Socket URL:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(87, 492);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 32);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 32);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtLicense
            // 
            this.txtLicense.Location = new System.Drawing.Point(128, 53);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(296, 20);
            this.txtLicense.TabIndex = 11;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(128, 94);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(296, 20);
            this.txtUsername.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 145);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(296, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // txtLeader
            // 
            this.txtLeader.Location = new System.Drawing.Point(128, 194);
            this.txtLeader.Name = "txtLeader";
            this.txtLeader.Size = new System.Drawing.Size(296, 20);
            this.txtLeader.TabIndex = 14;
            // 
            // txtProxy
            // 
            this.txtProxy.Location = new System.Drawing.Point(128, 376);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.Size = new System.Drawing.Size(296, 20);
            this.txtProxy.TabIndex = 16;
            // 
            // txtSocket
            // 
            this.txtSocket.Location = new System.Drawing.Point(128, 427);
            this.txtSocket.Name = "txtSocket";
            this.txtSocket.Size = new System.Drawing.Size(296, 20);
            this.txtSocket.TabIndex = 17;
            // 
            // txtStake
            // 
            this.txtStake.Location = new System.Drawing.Point(128, 246);
            this.txtStake.Name = "txtStake";
            this.txtStake.Size = new System.Drawing.Size(100, 20);
            this.txtStake.TabIndex = 18;
            // 
            // cBoxFollowLeader
            // 
            this.cBoxFollowLeader.AutoSize = true;
            this.cBoxFollowLeader.Location = new System.Drawing.Point(275, 248);
            this.cBoxFollowLeader.Name = "cBoxFollowLeader";
            this.cBoxFollowLeader.Size = new System.Drawing.Size(92, 17);
            this.cBoxFollowLeader.TabIndex = 19;
            this.cBoxFollowLeader.Text = "Follow Leader";
            this.cBoxFollowLeader.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(558, 554);
            this.Controls.Add(this.cBoxFollowLeader);
            this.Controls.Add(this.txtStake);
            this.Controls.Add(this.txtSocket);
            this.Controls.Add(this.txtProxy);
            this.Controls.Add(this.txtLeader);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSocket);
            this.Controls.Add(this.lblProxy);
            this.Controls.Add(this.lblBasic);
            this.Controls.Add(this.lblStake);
            this.Controls.Add(this.lblLeader);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblAccSettings);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblAccSettings;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLeader;
        private System.Windows.Forms.Label lblStake;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Label lblProxy;
        private System.Windows.Forms.Label lblSocket;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLeader;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.TextBox txtSocket;
        private System.Windows.Forms.TextBox txtStake;
        private System.Windows.Forms.CheckBox cBoxFollowLeader;
    }
}