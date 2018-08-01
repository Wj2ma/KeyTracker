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
            this.KpsBox = new System.Windows.Forms.Label();
            this.PeakKpsBox = new System.Windows.Forms.Label();
            this.TotalKeysBox = new System.Windows.Forms.Label();
            this.ElapsedTimeBox = new System.Windows.Forms.Label();
            this.LeftBox = new System.Windows.Forms.Label();
            this.DownBox = new System.Windows.Forms.Label();
            this.UpBox = new System.Windows.Forms.Label();
            this.RightBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusBox
            // 
            this.StatusBox.AutoSize = true;
            this.StatusBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.StatusBox.Location = new System.Drawing.Point(5, 5);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(65, 13);
            this.StatusBox.TabIndex = 10;
            this.StatusBox.Text = "STOPPED";
            // 
            // KpsBox
            // 
            this.KpsBox.AutoSize = true;
            this.KpsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KpsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.KpsBox.Location = new System.Drawing.Point(5, 60);
            this.KpsBox.Name = "KpsBox";
            this.KpsBox.Size = new System.Drawing.Size(46, 13);
            this.KpsBox.TabIndex = 11;
            this.KpsBox.Text = "KPS: 0";
            // 
            // PeakKpsBox
            // 
            this.PeakKpsBox.AutoSize = true;
            this.PeakKpsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeakKpsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.PeakKpsBox.Location = new System.Drawing.Point(5, 73);
            this.PeakKpsBox.Name = "PeakKpsBox";
            this.PeakKpsBox.Size = new System.Drawing.Size(79, 13);
            this.PeakKpsBox.TabIndex = 12;
            this.PeakKpsBox.Text = "Peak KPS: 0";
            // 
            // TotalKeysBox
            // 
            this.TotalKeysBox.AutoSize = true;
            this.TotalKeysBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalKeysBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.TotalKeysBox.Location = new System.Drawing.Point(5, 86);
            this.TotalKeysBox.Name = "TotalKeysBox";
            this.TotalKeysBox.Size = new System.Drawing.Size(82, 13);
            this.TotalKeysBox.TabIndex = 13;
            this.TotalKeysBox.Text = "Total Keys: 0";
            // 
            // ElapsedTimeBox
            // 
            this.ElapsedTimeBox.AutoSize = true;
            this.ElapsedTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElapsedTimeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ElapsedTimeBox.Location = new System.Drawing.Point(5, 99);
            this.ElapsedTimeBox.Name = "ElapsedTimeBox";
            this.ElapsedTimeBox.Size = new System.Drawing.Size(98, 13);
            this.ElapsedTimeBox.TabIndex = 14;
            this.ElapsedTimeBox.Text = "Elapsed Time: 0";
            // 
            // LeftBox
            // 
            this.LeftBox.BackColor = System.Drawing.Color.OldLace;
            this.LeftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftBox.Location = new System.Drawing.Point(8, 22);
            this.LeftBox.Name = "LeftBox";
            this.LeftBox.Size = new System.Drawing.Size(30, 30);
            this.LeftBox.TabIndex = 15;
            this.LeftBox.Text = "⭠";
            this.LeftBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DownBox
            // 
            this.DownBox.BackColor = System.Drawing.Color.OldLace;
            this.DownBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownBox.Location = new System.Drawing.Point(44, 22);
            this.DownBox.Name = "DownBox";
            this.DownBox.Size = new System.Drawing.Size(30, 30);
            this.DownBox.TabIndex = 16;
            this.DownBox.Text = "⭣";
            this.DownBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpBox
            // 
            this.UpBox.BackColor = System.Drawing.Color.OldLace;
            this.UpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpBox.Location = new System.Drawing.Point(80, 22);
            this.UpBox.Name = "UpBox";
            this.UpBox.Size = new System.Drawing.Size(30, 30);
            this.UpBox.TabIndex = 17;
            this.UpBox.Text = "⭡";
            this.UpBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightBox
            // 
            this.RightBox.BackColor = System.Drawing.Color.OldLace;
            this.RightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightBox.Location = new System.Drawing.Point(116, 22);
            this.RightBox.Name = "RightBox";
            this.RightBox.Size = new System.Drawing.Size(30, 30);
            this.RightBox.TabIndex = 18;
            this.RightBox.Text = "⭢";
            this.RightBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(248, 119);
            this.Controls.Add(this.RightBox);
            this.Controls.Add(this.UpBox);
            this.Controls.Add(this.DownBox);
            this.Controls.Add(this.LeftBox);
            this.Controls.Add(this.ElapsedTimeBox);
            this.Controls.Add(this.TotalKeysBox);
            this.Controls.Add(this.PeakKpsBox);
            this.Controls.Add(this.KpsBox);
            this.Controls.Add(this.StatusBox);
            this.KeyPreview = true;
            this.Name = "KeyTracker";
            this.Text = "KeyTracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label StatusBox;
        private System.Windows.Forms.Label KpsBox;
        private System.Windows.Forms.Label PeakKpsBox;
        private System.Windows.Forms.Label TotalKeysBox;
        private System.Windows.Forms.Label ElapsedTimeBox;
        private System.Windows.Forms.Label DownBox;
        private System.Windows.Forms.Label UpBox;
        private System.Windows.Forms.Label RightBox;
        private System.Windows.Forms.Label LeftBox;
    }
}

