namespace DrankjesSchema
{
    partial class DrankjesForm
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
            this.TotalDrinksLabel = new System.Windows.Forms.Label();
            this.DrinkAmountTextBox = new System.Windows.Forms.TextBox();
            this.DrinkSortTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DrinksList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TotalDrinksLabel
            // 
            this.TotalDrinksLabel.AutoSize = true;
            this.TotalDrinksLabel.Location = new System.Drawing.Point(329, 247);
            this.TotalDrinksLabel.Name = "TotalDrinksLabel";
            this.TotalDrinksLabel.Size = new System.Drawing.Size(118, 13);
            this.TotalDrinksLabel.TabIndex = 9;
            this.TotalDrinksLabel.Text = "Totaal aantal drankjes: ";
            // 
            // DrinkAmountTextBox
            // 
            this.DrinkAmountTextBox.Location = new System.Drawing.Point(32, 73);
            this.DrinkAmountTextBox.Name = "DrinkAmountTextBox";
            this.DrinkAmountTextBox.Size = new System.Drawing.Size(166, 20);
            this.DrinkAmountTextBox.TabIndex = 8;
            this.DrinkAmountTextBox.Text = "Aantal";
            // 
            // DrinkSortTextBox
            // 
            this.DrinkSortTextBox.Location = new System.Drawing.Point(32, 33);
            this.DrinkSortTextBox.Name = "DrinkSortTextBox";
            this.DrinkSortTextBox.Size = new System.Drawing.Size(166, 20);
            this.DrinkSortTextBox.TabIndex = 7;
            this.DrinkSortTextBox.Text = "Soort drankje";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.DimGray;
            this.AddButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddButton.Location = new System.Drawing.Point(74, 116);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 48);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Voeg toe";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DrinksList
            // 
            this.DrinksList.FormattingEnabled = true;
            this.DrinksList.Location = new System.Drawing.Point(231, 33);
            this.DrinksList.Name = "DrinksList";
            this.DrinksList.Size = new System.Drawing.Size(241, 199);
            this.DrinksList.TabIndex = 5;
            // 
            // DrankjesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 294);
            this.Controls.Add(this.TotalDrinksLabel);
            this.Controls.Add(this.DrinkAmountTextBox);
            this.Controls.Add(this.DrinkSortTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DrinksList);
            this.Name = "DrankjesForm";
            this.Text = "Drankjes Bestellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalDrinksLabel;
        private System.Windows.Forms.TextBox DrinkAmountTextBox;
        private System.Windows.Forms.TextBox DrinkSortTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox DrinksList;
    }
}