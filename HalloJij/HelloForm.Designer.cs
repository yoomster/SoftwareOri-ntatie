namespace HalloJij
{
    partial class HelloForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.ManButton = new System.Windows.Forms.RadioButton();
            this.WomanButton = new System.Windows.Forms.RadioButton();
            this.OkButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(91, 56);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(106, 13);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Voor- en achternaam";
            // 
            // ManButton
            // 
            this.ManButton.AutoSize = true;
            this.ManButton.Location = new System.Drawing.Point(203, 128);
            this.ManButton.Name = "ManButton";
            this.ManButton.Size = new System.Drawing.Size(46, 17);
            this.ManButton.TabIndex = 8;
            this.ManButton.TabStop = true;
            this.ManButton.Text = "Man";
            this.ManButton.UseVisualStyleBackColor = true;
            // 
            // WomanButton
            // 
            this.WomanButton.AutoSize = true;
            this.WomanButton.Location = new System.Drawing.Point(203, 94);
            this.WomanButton.Name = "WomanButton";
            this.WomanButton.Size = new System.Drawing.Size(55, 17);
            this.WomanButton.TabIndex = 7;
            this.WomanButton.TabStop = true;
            this.WomanButton.Text = "Vrouw";
            this.WomanButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(588, 152);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(98, 35);
            this.OkButton.TabIndex = 6;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(203, 49);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(242, 20);
            this.NameBox.TabIndex = 5;
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 236);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ManButton);
            this.Controls.Add(this.WomanButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.NameBox);
            this.Name = "HelloForm";
            this.Text = "HelloForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.RadioButton ManButton;
        private System.Windows.Forms.RadioButton WomanButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox NameBox;
    }
}