namespace KeyTracker {
    partial class KeyTracker {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.StatusBox = new System.Windows.Forms.Label();
            this.KpsLabel = new System.Windows.Forms.Label();
            this.PeakKpsLabel = new System.Windows.Forms.Label();
            this.TotalKeysLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.LeftBox = new System.Windows.Forms.Label();
            this.DownBox = new System.Windows.Forms.Label();
            this.UpBox = new System.Windows.Forms.Label();
            this.RightBox = new System.Windows.Forms.Label();
            this.KpsBox = new System.Windows.Forms.Label();
            this.PeakKpsBox = new System.Windows.Forms.Label();
            this.TotalKeysBox = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.StatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.ForeColor = System.Drawing.Color.Black;
            this.StatusBox.Location = new System.Drawing.Point(10, 10);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(380, 25);
            this.StatusBox.TabIndex = 10;
            this.StatusBox.MouseDown += this.StatusBox_MouseDown;
            // 
            // KpsLabel
            // 
            this.KpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KpsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.KpsLabel.Location = new System.Drawing.Point(16, 88);
            this.KpsLabel.Name = "KpsLabel";
            this.KpsLabel.Size = new System.Drawing.Size(61, 42);
            this.KpsLabel.TabIndex = 11;
            this.KpsLabel.Text = "KPS:";
            this.KpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KpsLabel.MouseDown += this.KpsLabel_MouseDown;
            // 
            // PeakKpsLabel
            // 
            this.PeakKpsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeakKpsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.PeakKpsLabel.Location = new System.Drawing.Point(13, 130);
            this.PeakKpsLabel.Name = "PeakKpsLabel";
            this.PeakKpsLabel.Size = new System.Drawing.Size(64, 42);
            this.PeakKpsLabel.TabIndex = 12;
            this.PeakKpsLabel.Text = "Peak:";
            this.PeakKpsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PeakKpsLabel.MouseDown += this.PeakKpsLabel_MouseDown;
            // 
            // TotalKeysLabel
            // 
            this.TotalKeysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalKeysLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.TotalKeysLabel.Location = new System.Drawing.Point(158, 88);
            this.TotalKeysLabel.Name = "TotalKeysLabel";
            this.TotalKeysLabel.Size = new System.Drawing.Size(98, 42);
            this.TotalKeysLabel.TabIndex = 13;
            this.TotalKeysLabel.Text = "Total Keys:";
            this.TotalKeysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalKeysLabel.MouseDown += this.TotalKeysLabel_MouseDown;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.TimeLabel.Location = new System.Drawing.Point(158, 130);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(98, 42);
            this.TimeLabel.TabIndex = 14;
            this.TimeLabel.Text = "Time:";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimeLabel.MouseDown += this.TimeLabel_MouseDown;
            // 
            // LeftBox
            // 
            this.LeftBox.BackColor = System.Drawing.Color.OldLace;
            this.LeftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.LeftBox.Location = new System.Drawing.Point(105, 45);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.Size = new System.Drawing.Size(40, 40);
            this.LeftBox.TabIndex = 15;
            this.LeftBox.Text = "◀";
            this.LeftBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LeftBox.MouseDown += this.LeftBox_MouseDown;
            // 
            // DownBox
            // 
            this.DownBox.BackColor = System.Drawing.Color.OldLace;
            this.DownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.DownBox.Location = new System.Drawing.Point(155, 45);
            this.DownBox.Name = "DownBox";
            this.DownBox.Size = new System.Drawing.Size(40, 40);
            this.DownBox.TabIndex = 16;
            this.DownBox.Text = "▼";
            this.DownBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DownBox.MouseDown += this.DownBox_MouseDown;
            // 
            // UpBox
            // 
            this.UpBox.BackColor = System.Drawing.Color.OldLace;
            this.UpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.UpBox.Location = new System.Drawing.Point(205, 45);
            this.UpBox.Name = "UpBox";
            this.UpBox.Size = new System.Drawing.Size(40, 40);
            this.UpBox.TabIndex = 17;
            this.UpBox.Text = "▲";
            this.UpBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpBox.MouseDown += this.UpBox_MouseDown;
            // 
            // RightBox
            // 
            this.RightBox.BackColor = System.Drawing.Color.OldLace;
            this.RightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.RightBox.Location = new System.Drawing.Point(255, 45);
            this.RightBox.Name = "RightBox";
            this.RightBox.Size = new System.Drawing.Size(40, 40);
            this.RightBox.TabIndex = 18;
            this.RightBox.Text = "▶";
            this.RightBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RightBox.MouseDown += this.RightBox_MouseDown;
            // 
            // KpsBox
            // 
            this.KpsBox.AutoSize = true;
            this.KpsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KpsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.KpsBox.Location = new System.Drawing.Point(71, 88);
            this.KpsBox.Name = "KpsBox";
            this.KpsBox.Size = new System.Drawing.Size(40, 42);
            this.KpsBox.TabIndex = 19;
            this.KpsBox.Text = "0";
            this.KpsBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KpsBox.MouseDown += this.KpsBox_MouseDown;
            // 
            // PeakKpsBox
            // 
            this.PeakKpsBox.AutoSize = true;
            this.PeakKpsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeakKpsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.PeakKpsBox.Location = new System.Drawing.Point(71, 130);
            this.PeakKpsBox.Name = "PeakKpsBox";
            this.PeakKpsBox.Size = new System.Drawing.Size(40, 42);
            this.PeakKpsBox.TabIndex = 20;
            this.PeakKpsBox.Text = "0";
            this.PeakKpsBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PeakKpsBox.MouseDown += this.PeakKpsBox_MouseDown;
            // 
            // TotalKeysBox
            // 
            this.TotalKeysBox.AutoSize = true;
            this.TotalKeysBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalKeysBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.TotalKeysBox.Location = new System.Drawing.Point(249, 88);
            this.TotalKeysBox.Name = "TotalKeysBox";
            this.TotalKeysBox.Size = new System.Drawing.Size(40, 42);
            this.TotalKeysBox.TabIndex = 21;
            this.TotalKeysBox.Text = "0";
            this.TotalKeysBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TotalKeysBox.MouseDown += this.TotalKeysBox_MouseDown;
            // 
            // TimeBox
            // 
            this.TimeBox.AutoSize = true;
            this.TimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.TimeBox.Location = new System.Drawing.Point(249, 130);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(40, 42);
            this.TimeBox.TabIndex = 22;
            this.TimeBox.Text = "0";
            this.TimeBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimeBox.MouseDown += this.TimeBox_MouseDown;
            // 
            // KeyTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(400, 175);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.TotalKeysBox);
            this.Controls.Add(this.PeakKpsBox);
            this.Controls.Add(this.KpsBox);
            this.Controls.Add(this.RightBox);
            this.Controls.Add(this.UpBox);
            this.Controls.Add(this.DownBox);
            this.Controls.Add(this.LeftBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TotalKeysLabel);
            this.Controls.Add(this.PeakKpsLabel);
            this.Controls.Add(this.KpsLabel);
            this.Controls.Add(this.StatusBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "KeyTracker";
            this.Text = "KeyTracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StatusBox;
        private System.Windows.Forms.Label PeakKpsLabel;
        private System.Windows.Forms.Label TotalKeysLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DownBox;
        private System.Windows.Forms.Label UpBox;
        private System.Windows.Forms.Label RightBox;
        private System.Windows.Forms.Label LeftBox;
        private System.Windows.Forms.Label KpsLabel;
        private System.Windows.Forms.Label KpsBox;
        private System.Windows.Forms.Label PeakKpsBox;
        private System.Windows.Forms.Label TotalKeysBox;
        private System.Windows.Forms.Label TimeBox;
    }
}

