namespace FluxVakanties
{
    partial class EurToUsdConverter
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
            this.EuroTextBox = new System.Windows.Forms.TextBox();
            this.DollarTextBox = new System.Windows.Forms.TextBox();
            this.EuroLabel = new System.Windows.Forms.Label();
            this.DollarLabel = new System.Windows.Forms.Label();
            this.EuroButton = new System.Windows.Forms.Button();
            this.DollarButton = new System.Windows.Forms.Button();
            this.DollarExchangeRate = new System.Windows.Forms.DomainUpDown();
            this.ExchangeRateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EuroTextBox
            // 
            this.EuroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EuroTextBox.Location = new System.Drawing.Point(101, 86);
            this.EuroTextBox.Name = "EuroTextBox";
            this.EuroTextBox.Size = new System.Drawing.Size(166, 26);
            this.EuroTextBox.TabIndex = 0;
            // 
            // DollarTextBox
            // 
            this.DollarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DollarTextBox.Location = new System.Drawing.Point(415, 86);
            this.DollarTextBox.Name = "DollarTextBox";
            this.DollarTextBox.Size = new System.Drawing.Size(161, 26);
            this.DollarTextBox.TabIndex = 1;
            // 
            // EuroLabel
            // 
            this.EuroLabel.AutoSize = true;
            this.EuroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroLabel.Location = new System.Drawing.Point(34, 71);
            this.EuroLabel.Name = "EuroLabel";
            this.EuroLabel.Size = new System.Drawing.Size(51, 55);
            this.EuroLabel.TabIndex = 2;
            this.EuroLabel.Text = "€";
            // 
            // DollarLabel
            // 
            this.DollarLabel.AutoSize = true;
            this.DollarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarLabel.Location = new System.Drawing.Point(595, 71);
            this.DollarLabel.Name = "DollarLabel";
            this.DollarLabel.Size = new System.Drawing.Size(51, 55);
            this.DollarLabel.TabIndex = 3;
            this.DollarLabel.Text = "$";
            // 
            // EuroButton
            // 
            this.EuroButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EuroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EuroButton.Location = new System.Drawing.Point(283, 78);
            this.EuroButton.Name = "EuroButton";
            this.EuroButton.Size = new System.Drawing.Size(53, 42);
            this.EuroButton.TabIndex = 4;
            this.EuroButton.Text = "<";
            this.EuroButton.UseVisualStyleBackColor = false;
            // 
            // DollarButton
            // 
            this.DollarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DollarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DollarButton.Location = new System.Drawing.Point(342, 78);
            this.DollarButton.Name = "DollarButton";
            this.DollarButton.Size = new System.Drawing.Size(55, 42);
            this.DollarButton.TabIndex = 5;
            this.DollarButton.Text = ">";
            this.DollarButton.UseVisualStyleBackColor = false;
            // 
            // DollarExchangeRate
            // 
            this.DollarExchangeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DollarExchangeRate.Location = new System.Drawing.Point(364, 166);
            this.DollarExchangeRate.Name = "DollarExchangeRate";
            this.DollarExchangeRate.Size = new System.Drawing.Size(55, 26);
            this.DollarExchangeRate.TabIndex = 6;
            this.DollarExchangeRate.Text = "2,00";
            // 
            // ExchangeRateLabel
            // 
            this.ExchangeRateLabel.AutoSize = true;
            this.ExchangeRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeRateLabel.Location = new System.Drawing.Point(229, 168);
            this.ExchangeRateLabel.Name = "ExchangeRateLabel";
            this.ExchangeRateLabel.Size = new System.Drawing.Size(129, 20);
            this.ExchangeRateLabel.TabIndex = 7;
            this.ExchangeRateLabel.Text = "Koers: 1 euro = $";
            // 
            // EurToUsdConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 217);
            this.Controls.Add(this.ExchangeRateLabel);
            this.Controls.Add(this.DollarExchangeRate);
            this.Controls.Add(this.DollarButton);
            this.Controls.Add(this.EuroButton);
            this.Controls.Add(this.DollarLabel);
            this.Controls.Add(this.EuroLabel);
            this.Controls.Add(this.DollarTextBox);
            this.Controls.Add(this.EuroTextBox);
            this.Name = "EurToUsdConverter";
            this.Text = "Euro - US Dollar Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EuroTextBox;
        private System.Windows.Forms.TextBox DollarTextBox;
        private System.Windows.Forms.Label EuroLabel;
        private System.Windows.Forms.Label DollarLabel;
        private System.Windows.Forms.Button EuroButton;
        private System.Windows.Forms.Button DollarButton;
        private System.Windows.Forms.DomainUpDown DollarExchangeRate;
        private System.Windows.Forms.Label ExchangeRateLabel;
    }
}

