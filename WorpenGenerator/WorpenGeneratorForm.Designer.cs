﻿namespace WorpenGenerator
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
            this.ThrowsLabel = new System.Windows.Forms.Label();
            this.DiceThrowsList = new System.Windows.Forms.ListBox();
            this.SettingsBox = new System.Windows.Forms.GroupBox();
            this.AmountOfThrowsLabel = new System.Windows.Forms.Label();
            this.PipsLabel = new System.Windows.Forms.Label();
            this.ThrowsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.PipsNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.ThrowDiceButton = new System.Windows.Forms.Button();
            this.TotalPipsLabel = new System.Windows.Forms.Label();
            this.ResultBox.SuspendLayout();
            this.SettingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThrowsNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipsNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultBox
            // 
            this.ResultBox.Controls.Add(this.TotalPipsLabel);
            this.ResultBox.Controls.Add(this.ThrowsLabel);
            this.ResultBox.Controls.Add(this.DiceThrowsList);
            this.ResultBox.Location = new System.Drawing.Point(341, 34);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(235, 268);
            this.ResultBox.TabIndex = 0;
            this.ResultBox.TabStop = false;
            this.ResultBox.Text = "Resultaat";
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
            this.SettingsBox.Controls.Add(this.ThrowDiceButton);
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
            // AmountOfThrowsLabel
            // 
            this.AmountOfThrowsLabel.AutoSize = true;
            this.AmountOfThrowsLabel.Location = new System.Drawing.Point(3, 16);
            this.AmountOfThrowsLabel.Name = "AmountOfThrowsLabel";
            this.AmountOfThrowsLabel.Size = new System.Drawing.Size(78, 13);
            this.AmountOfThrowsLabel.TabIndex = 0;
            this.AmountOfThrowsLabel.Text = "Aantal worpen:";
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
            // ThrowsNumUpDown
            // 
            this.ThrowsNumUpDown.Location = new System.Drawing.Point(153, 16);
            this.ThrowsNumUpDown.Name = "ThrowsNumUpDown";
            this.ThrowsNumUpDown.Size = new System.Drawing.Size(83, 20);
            this.ThrowsNumUpDown.TabIndex = 3;
            this.ThrowsNumUpDown.ValueChanged += new System.EventHandler(this.ThrowsNumUpDown_ValueChanged);
            // 
            // PipsNumUpDown
            // 
            this.PipsNumUpDown.Location = new System.Drawing.Point(154, 44);
            this.PipsNumUpDown.Name = "PipsNumUpDown";
            this.PipsNumUpDown.Size = new System.Drawing.Size(81, 20);
            this.PipsNumUpDown.TabIndex = 4;
            // 
            // ThrowDiceButton
            // 
            this.ThrowDiceButton.Location = new System.Drawing.Point(102, 70);
            this.ThrowDiceButton.Name = "ThrowDiceButton";
            this.ThrowDiceButton.Size = new System.Drawing.Size(120, 23);
            this.ThrowDiceButton.TabIndex = 5;
            this.ThrowDiceButton.Text = "Gooi dobbelsteen";
            this.ThrowDiceButton.UseVisualStyleBackColor = true;
            this.ThrowDiceButton.Click += new System.EventHandler(this.ThrowDiceButton_Click);
            // 
            // TotalPipsLabel
            // 
            this.TotalPipsLabel.AutoSize = true;
            this.TotalPipsLabel.Location = new System.Drawing.Point(21, 239);
            this.TotalPipsLabel.Name = "TotalPipsLabel";
            this.TotalPipsLabel.Size = new System.Drawing.Size(99, 13);
            this.TotalPipsLabel.TabIndex = 2;
            this.TotalPipsLabel.Text = "Totaal aantal ogen:";
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
            ((System.ComponentModel.ISupportInitialize)(this.ThrowsNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipsNumUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ResultBox;
        private System.Windows.Forms.Label ThrowsLabel;
        private System.Windows.Forms.ListBox DiceThrowsList;
        private System.Windows.Forms.GroupBox SettingsBox;
        private System.Windows.Forms.Button ThrowDiceButton;
        private System.Windows.Forms.NumericUpDown PipsNumUpDown;
        private System.Windows.Forms.NumericUpDown ThrowsNumUpDown;
        private System.Windows.Forms.Label PipsLabel;
        private System.Windows.Forms.Label AmountOfThrowsLabel;
        private System.Windows.Forms.Label TotalPipsLabel;
    }
}