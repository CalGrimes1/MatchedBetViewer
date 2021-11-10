namespace BetBot7
{
    partial class frmOdds
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.rtbxLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 538);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(136, 50);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(619, 538);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 50);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(761, 538);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(136, 50);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(903, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(27, 41);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(58, 13);
            this.lblLog.TabIndex = 7;
            this.lblLog.Text = "Status Log";
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Location = new System.Drawing.Point(829, 41);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(50, 13);
            this.lblAcc.TabIndex = 8;
            this.lblAcc.Text = "Account:";
            // 
            // rtbxLog
            // 
            this.rtbxLog.Location = new System.Drawing.Point(11, 66);
            this.rtbxLog.Name = "rtbxLog";
            this.rtbxLog.Size = new System.Drawing.Size(1027, 461);
            this.rtbxLog.TabIndex = 9;
            this.rtbxLog.Text = "";
            // 
            // frmOdds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 600);
            this.Controls.Add(this.rtbxLog);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSettings);
            this.Name = "frmOdds";
            this.Text = "Bet365 Odds";
            this.Load += new System.EventHandler(this.frmOdds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.RichTextBox rtbxLog;
    }
}

