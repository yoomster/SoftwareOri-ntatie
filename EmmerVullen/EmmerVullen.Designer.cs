namespace EmmerVullen
{
    partial class EmmerVullen
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
            this.BucketSizeTextBox = new System.Windows.Forms.TextBox();
            this.BucketSizeLabel = new System.Windows.Forms.Label();
            this.CupSizeLabel = new System.Windows.Forms.Label();
            this.CupSizeTextBox = new System.Windows.Forms.TextBox();
            this.ButtonFillBucket = new System.Windows.Forms.Button();
            this.BucketProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BucketSizeTextBox
            // 
            this.BucketSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BucketSizeTextBox.Location = new System.Drawing.Point(412, 213);
            this.BucketSizeTextBox.Name = "BucketSizeTextBox";
            this.BucketSizeTextBox.Size = new System.Drawing.Size(167, 29);
            this.BucketSizeTextBox.TabIndex = 1;
            // 
            // BucketSizeLabel
            // 
            this.BucketSizeLabel.AutoSize = true;
            this.BucketSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BucketSizeLabel.Location = new System.Drawing.Point(232, 218);
            this.BucketSizeLabel.Name = "BucketSizeLabel";
            this.BucketSizeLabel.Size = new System.Drawing.Size(174, 24);
            this.BucketSizeLabel.TabIndex = 1;
            this.BucketSizeLabel.Text = "Emmer grootte (lit): ";
            // 
            // CupSizeLabel
            // 
            this.CupSizeLabel.AutoSize = true;
            this.CupSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CupSizeLabel.Location = new System.Drawing.Point(243, 257);
            this.CupSizeLabel.Name = "CupSizeLabel";
            this.CupSizeLabel.Size = new System.Drawing.Size(163, 24);
            this.CupSizeLabel.TabIndex = 3;
            this.CupSizeLabel.Text = "Beker grootte (cl:) ";
            // 
            // CupSizeTextBox
            // 
            this.CupSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CupSizeTextBox.Location = new System.Drawing.Point(412, 254);
            this.CupSizeTextBox.Name = "CupSizeTextBox";
            this.CupSizeTextBox.Size = new System.Drawing.Size(167, 29);
            this.CupSizeTextBox.TabIndex = 2;
            // 
            // ButtonFillBucket
            // 
            this.ButtonFillBucket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonFillBucket.Location = new System.Drawing.Point(235, 71);
            this.ButtonFillBucket.Name = "ButtonFillBucket";
            this.ButtonFillBucket.Size = new System.Drawing.Size(190, 69);
            this.ButtonFillBucket.TabIndex = 3;
            this.ButtonFillBucket.Text = "Vullen met water";
            this.ButtonFillBucket.UseVisualStyleBackColor = true;
            this.ButtonFillBucket.Click += new System.EventHandler(this.ButtonFillBucket_Click);
            // 
            // BucketProgressBar
            // 
            this.BucketProgressBar.Location = new System.Drawing.Point(25, 28);
            this.BucketProgressBar.Name = "BucketProgressBar";
            this.BucketProgressBar.Size = new System.Drawing.Size(158, 286);
            this.BucketProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BucketProgressBar.TabIndex = 5;
            this.BucketProgressBar.Value = 60;
            // 
            // EmmerVullen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 337);
            this.Controls.Add(this.BucketProgressBar);
            this.Controls.Add(this.ButtonFillBucket);
            this.Controls.Add(this.CupSizeLabel);
            this.Controls.Add(this.CupSizeTextBox);
            this.Controls.Add(this.BucketSizeLabel);
            this.Controls.Add(this.BucketSizeTextBox);
            this.Name = "EmmerVullen";
            this.Text = "Emmer vullen met water";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BucketSizeTextBox;
        private System.Windows.Forms.Label BucketSizeLabel;
        private System.Windows.Forms.Label CupSizeLabel;
        private System.Windows.Forms.TextBox CupSizeTextBox;
        private System.Windows.Forms.Button ButtonFillBucket;
        private System.Windows.Forms.ProgressBar BucketProgressBar;
    }
}