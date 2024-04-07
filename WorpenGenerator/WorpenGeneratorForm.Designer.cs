namespace WorpenGenerator
{
    partial class WorpenGeneratorForm
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
            this.ResultBox = new System.Windows.Forms.GroupBox();
            this.TotalPipsTxtLabel = new System.Windows.Forms.Label();
            this.ThrowsLabel = new System.Windows.Forms.Label();
            this.DiceThrowsList = new System.Windows.Forms.ListBox();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.ButtonThrowDice = new System.Windows.Forms.Button();
            this.PipsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.ThrowsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.PipsLabel = new System.Windows.Forms.Label();
            this.AmountOfThrowsLabel = new System.Windows.Forms.Label();
            this.TotalPipslabel = new System.Windows.Forms.Label();
            this.ResultBox.SuspendLayout();
            this.SettingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PipsNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrowsNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.Controls.Add(this.TotalPipslabel);
            this.ResultBox.Controls.Add(this.TotalPipsTxtLabel);
            this.ResultBox.Controls.Add(this.ThrowsLabel);
            this.ResultBox.Controls.Add(this.DiceThrowsList);
            this.ResultBox.Location = new System.Drawing.Point(341, 34);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(235, 268);
            this.ResultBox.TabIndex = 0;
            this.ResultBox.TabStop = false;
            this.ResultBox.Text = "Resultaat";
            // 
            // TotalPipsTxtLabel
            // 
            this.TotalPipsTxtLabel.AutoSize = true;
            this.TotalPipsTxtLabel.Location = new System.Drawing.Point(21, 239);
            this.TotalPipsTxtLabel.Name = "TotalPipsTxtLabel";
            this.TotalPipsTxtLabel.Size = new System.Drawing.Size(99, 13);
            this.TotalPipsTxtLabel.TabIndex = 2;
            this.TotalPipsTxtLabel.Text = "Totaal aantal ogen:";
            // 
            // ThrowsLabel
            // 
            this.ThrowsLabel.AutoSize = true;
            this.ThrowsLabel.Location = new System.Drawing.Point(6, 25);
            this.ThrowsLabel.Name = "ThrowsLabel";
            this.ThrowsLabel.Size = new System.Drawing.Size(48, 13);
            this.ThrowsLabel.TabIndex = 1;
            this.ThrowsLabel.Text = "Worpen:";
            // 
            // DiceThrowsList
            // 
            this.DiceThrowsList.FormattingEnabled = true;
            this.DiceThrowsList.Location = new System.Drawing.Point(6, 54);
            this.DiceThrowsList.Name = "DiceThrowsList";
            this.DiceThrowsList.Size = new System.Drawing.Size(219, 173);
            this.DiceThrowsList.TabIndex = 0;
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.ButtonThrowDice);
            this.SettingsBox.Controls.Add(this.PipsNumUpDown);
            this.SettingsBox.Controls.Add(this.ThrowsNumUpDown);
            this.SettingsBox.Controls.Add(this.PipsLabel);
            this.SettingsBox.Controls.Add(this.AmountOfThrowsLabel);
            this.SettingsBox.Location = new System.Drawing.Point(27, 83);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(293, 113);
            this.SettingsBox.TabIndex = 1;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Text = "Instellingen";
            // 
            // ButtonThrowDice
            // 
            this.ButtonThrowDice.Location = new System.Drawing.Point(102, 70);
            this.ButtonThrowDice.Name = "ButtonThrowDice";
            this.ButtonThrowDice.Size = new System.Drawing.Size(120, 23);
            this.ButtonThrowDice.TabIndex = 3;
            this.ButtonThrowDice.Text = "Gooi dobbelsteen";
            this.ButtonThrowDice.UseVisualStyleBackColor = true;
            this.ButtonThrowDice.Click += new System.EventHandler(this.ButtonThrowDice_Click);
            // 
            // PipsNumUpDown
            // 
            this.PipsNumUpDown.Location = new System.Drawing.Point(154, 44);
            this.PipsNumUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PipsNumUpDown.Name = "PipsNumUpDown";
            this.PipsNumUpDown.Size = new System.Drawing.Size(81, 20);
            this.PipsNumUpDown.TabIndex = 2;
            this.PipsNumUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // ThrowsNumUpDown
            // 
            this.ThrowsNumUpDown.Location = new System.Drawing.Point(153, 16);
            this.ThrowsNumUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ThrowsNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ThrowsNumUpDown.Name = "ThrowsNumUpDown";
            this.ThrowsNumUpDown.Size = new System.Drawing.Size(83, 20);
            this.ThrowsNumUpDown.TabIndex = 1;
            this.ThrowsNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PipsLabel
            // 
            this.PipsLabel.AutoSize = true;
            this.PipsLabel.Location = new System.Drawing.Point(6, 48);
            this.PipsLabel.Name = "PipsLabel";
            this.PipsLabel.Size = new System.Drawing.Size(67, 13);
            this.PipsLabel.TabIndex = 2;
            this.PipsLabel.Text = "Aantal ogen:";
            // 
            // AmountOfThrowsLabel
            // 
            this.AmountOfThrowsLabel.AutoSize = true;
            this.AmountOfThrowsLabel.Location = new System.Drawing.Point(3, 16);
            this.AmountOfThrowsLabel.Name = "AmountOfThrowsLabel";
            this.AmountOfThrowsLabel.Size = new System.Drawing.Size(78, 13);
            this.AmountOfThrowsLabel.TabIndex = 0;
            this.AmountOfThrowsLabel.Text = "Aantal worpen:";
            // 
            // TotalPipslabel
            // 
            this.TotalPipslabel.AutoSize = true;
            this.TotalPipslabel.Location = new System.Drawing.Point(163, 239);
            this.TotalPipslabel.Name = "TotalPipslabel";
            this.TotalPipslabel.Size = new System.Drawing.Size(13, 13);
            this.TotalPipslabel.TabIndex = 3;
            this.TotalPipslabel.Text = "0";
            // 
            // WorpenGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 339);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.ResultBox);
            this.Name = "WorpenGeneratorForm";
            this.Text = "Dobbelsteen worpengenerator";
            this.ResultBox.ResumeLayout(false);
            this.ResultBox.PerformLayout();
            this.SettingsBox.ResumeLayout(false);
            this.SettingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PipsNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThrowsNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ResultBox;
        private System.Windows.Forms.Label ThrowsLabel;
        private System.Windows.Forms.ListBox DiceThrowsList;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.Button ButtonThrowDice;
        private System.Windows.Forms.NumericUpDown PipsNumUpDown;
        private System.Windows.Forms.NumericUpDown ThrowsNumUpDown;
        private System.Windows.Forms.Label PipsLabel;
        private System.Windows.Forms.Label AmountOfThrowsLabel;
        private System.Windows.Forms.Label TotalPipsTxtLabel;
        private System.Windows.Forms.Label TotalPipslabel;
    }
}