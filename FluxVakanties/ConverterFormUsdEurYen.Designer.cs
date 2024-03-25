namespace FluxVakanties
{
    partial class ConverterFormUsdEurYen
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
            this.ExchangeRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExchangeRateLabel = new System.Windows.Forms.Label();
            this.ConvertToYenOrDollarButton = new System.Windows.Forms.Button();
            this.ConvertToEuroButton = new System.Windows.Forms.Button();
            this.DollarLabel = new System.Windows.Forms.Label();
            this.EuroLabel = new System.Windows.Forms.Label();
            this.DollarTextBox = new System.Windows.Forms.TextBox();
            this.EuroTextBox = new System.Windows.Forms.TextBox();
            this.DropDownValutaBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ExchangeRateNumericUpDown
            // 
            this.ExchangeRateNumericUpDown.DecimalPlaces = 2;
            this.ExchangeRateNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ExchangeRateNumericUpDown.Location = new System.Drawing.Point(392, 155);
            this.ExchangeRateNumericUpDown.Name = "ExchangeRateNumericUpDown";
            this.ExchangeRateNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.ExchangeRateNumericUpDown.TabIndex = 16;
            this.ExchangeRateNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ExchangeRateLabel
            // 
            this.ExchangeRateLabel.AutoSize = true;
            this.ExchangeRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeRateLabel.Location = new System.Drawing.Point(257, 155);
            this.ExchangeRateLabel.Name = "ExchangeRateLabel";
            this.ExchangeRateLabel.Size = new System.Drawing.Size(129, 20);
            this.ExchangeRateLabel.TabIndex = 15;
            this.ExchangeRateLabel.Text = "Koers: 1 euro = $";
            // 
            // ConvertToYenOrDollarButton
            // 
            this.ConvertToYenOrDollarButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConvertToYenOrDollarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConvertToYenOrDollarButton.Location = new System.Drawing.Point(370, 65);
            this.ConvertToYenOrDollarButton.Name = "ConvertToYenOrDollarButton";
            this.ConvertToYenOrDollarButton.Size = new System.Drawing.Size(55, 42);
            this.ConvertToYenOrDollarButton.TabIndex = 14;
            this.ConvertToYenOrDollarButton.Text = ">";
            this.ConvertToYenOrDollarButton.UseVisualStyleBackColor = false;
            this.ConvertToYenOrDollarButton.Click += new System.EventHandler(this.ConvertToYenOrDollarButton_Click);
            // 
            // ConvertToEuroButton
            // 
            this.ConvertToEuroButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ConvertToEuroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConvertToEuroButton.Location = new System.Drawing.Point(311, 65);
            this.ConvertToEuroButton.Name = "ConvertToEuroButton";
            this.ConvertToEuroButton.Size = new System.Drawing.Size(53, 42);
            this.ConvertToEuroButton.TabIndex = 13;
            this.ConvertToEuroButton.Text = "<";
            this.ConvertToEuroButton.UseVisualStyleBackColor = false;
            this.ConvertToEuroButton.Click += new System.EventHandler(this.ConvertToEuroButton_Click);
            // 
            // DollarLabel
            // 
            this.DollarLabel.AutoSize = true;
            this.DollarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarLabel.Location = new System.Drawing.Point(623, 58);
            this.DollarLabel.Name = "DollarLabel";
            this.DollarLabel.Size = new System.Drawing.Size(51, 55);
            this.DollarLabel.TabIndex = 12;
            this.DollarLabel.Text = "$";
            // 
            // EuroLabel
            // 
            this.EuroLabel.AutoSize = true;
            this.EuroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroLabel.Location = new System.Drawing.Point(62, 58);
            this.EuroLabel.Name = "EuroLabel";
            this.EuroLabel.Size = new System.Drawing.Size(51, 55);
            this.EuroLabel.TabIndex = 11;
            this.EuroLabel.Text = "€";
            // 
            // DollarTextBox
            // 
            this.DollarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DollarTextBox.Location = new System.Drawing.Point(443, 73);
            this.DollarTextBox.Name = "DollarTextBox";
            this.DollarTextBox.Size = new System.Drawing.Size(161, 26);
            this.DollarTextBox.TabIndex = 10;
            // 
            // EuroTextBox
            // 
            this.EuroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EuroTextBox.Location = new System.Drawing.Point(129, 73);
            this.EuroTextBox.Name = "EuroTextBox";
            this.EuroTextBox.Size = new System.Drawing.Size(166, 26);
            this.EuroTextBox.TabIndex = 9;
            // 
            // DropDownValutaBox
            // 
            this.DropDownValutaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.DropDownValutaBox.FormattingEnabled = true;
            this.DropDownValutaBox.Items.AddRange(new object[] {
            "$ USD",
            "¥ JPY"});
            this.DropDownValutaBox.Location = new System.Drawing.Point(614, 124);
            this.DropDownValutaBox.Name = "DropDownValutaBox";
            this.DropDownValutaBox.Size = new System.Drawing.Size(60, 63);
            this.DropDownValutaBox.TabIndex = 17;
            this.DropDownValutaBox.SelectedIndexChanged += new System.EventHandler(this.DropDownValutaBox_SelectedIndexChanged);
            // 
            // ConverterFormUsdEurYen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 219);
            this.Controls.Add(this.DropDownValutaBox);
            this.Controls.Add(this.ExchangeRateNumericUpDown);
            this.Controls.Add(this.ExchangeRateLabel);
            this.Controls.Add(this.ConvertToYenOrDollarButton);
            this.Controls.Add(this.ConvertToEuroButton);
            this.Controls.Add(this.DollarLabel);
            this.Controls.Add(this.EuroLabel);
            this.Controls.Add(this.DollarTextBox);
            this.Controls.Add(this.EuroTextBox);
            this.Name = "ConverterFormUsdEurYen";
            this.Text = "ConverterFormUsdEurYen";
            ((System.ComponentModel.ISupportInitialize)(this.ExchangeRateNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ExchangeRateNumericUpDown;
        private System.Windows.Forms.Label ExchangeRateLabel;
        private System.Windows.Forms.Button ConvertToYenOrDollarButton;
        private System.Windows.Forms.Button ConvertToEuroButton;
        private System.Windows.Forms.Label DollarLabel;
        private System.Windows.Forms.Label EuroLabel;
        public System.Windows.Forms.TextBox DollarTextBox;
        private System.Windows.Forms.TextBox EuroTextBox;
        private System.Windows.Forms.ComboBox DropDownValutaBox;
    }
}