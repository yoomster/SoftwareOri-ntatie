namespace EmmerVolLatenLopen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            BucketProgressBar = new ProgressBar();
            BucketSizeTxtBox = new TextBox();
            BucketLabel = new Label();
            CupLabel = new Label();
            CupSizeTxtBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F);
            button1.Location = new Point(335, 60);
            button1.Name = "button1";
            button1.Size = new Size(240, 102);
            button1.TabIndex = 0;
            button1.Text = "Vullen met water";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BucketProgressBar
            // 
            BucketProgressBar.Location = new Point(32, 31);
            BucketProgressBar.Name = "BucketProgressBar";
            BucketProgressBar.Size = new Size(229, 382);
            BucketProgressBar.TabIndex = 1;
            // 
            // BucketSizeTxtBox
            // 
            BucketSizeTxtBox.Font = new Font("Segoe UI", 14.25F);
            BucketSizeTxtBox.Location = new Point(464, 239);
            BucketSizeTxtBox.Name = "BucketSizeTxtBox";
            BucketSizeTxtBox.Size = new Size(155, 33);
            BucketSizeTxtBox.TabIndex = 2;
            // 
            // BucketLabel
            // 
            BucketLabel.AutoSize = true;
            BucketLabel.Font = new Font("Segoe UI", 14.25F);
            BucketLabel.Location = new Point(295, 247);
            BucketLabel.Name = "BucketLabel";
            BucketLabel.Size = new Size(142, 25);
            BucketLabel.TabIndex = 3;
            BucketLabel.Text = "Emmer grootte:";
            // 
            // CupLabel
            // 
            CupLabel.AutoSize = true;
            CupLabel.Font = new Font("Segoe UI", 14.25F);
            CupLabel.Location = new Point(295, 289);
            CupLabel.Name = "CupLabel";
            CupLabel.Size = new Size(130, 25);
            CupLabel.TabIndex = 5;
            CupLabel.Text = "Beker grootte:";
            // 
            // CupSizeTxtBox
            // 
            CupSizeTxtBox.Font = new Font("Segoe UI", 14.25F);
            CupSizeTxtBox.Location = new Point(464, 281);
            CupSizeTxtBox.Name = "CupSizeTxtBox";
            CupSizeTxtBox.Size = new Size(155, 33);
            CupSizeTxtBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CupLabel);
            Controls.Add(CupSizeTxtBox);
            Controls.Add(BucketLabel);
            Controls.Add(BucketSizeTxtBox);
            Controls.Add(BucketProgressBar);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ProgressBar BucketProgressBar;
        private TextBox BucketSizeTxtBox;
        private Label BucketLabel;
        private Label CupLabel;
        private TextBox CupSizeTxtBox;
    }
}
