namespace VanDerBinckesBakfietsen
{
    partial class BakfietsVerhuur
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
            BikeLabel = new Label();
            RentDaysLabel = new Label();
            ExtrasLabel = new Label();
            CostsPerDayLabel = new Label();
            ButtonCalculateCost = new Button();
            RentalDaysNumUpDown = new NumericUpDown();
            AccessoiresList = new CheckedListBox();
            ChoiceOfBikes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)RentalDaysNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // BikeLabel
            // 
            BikeLabel.AutoSize = true;
            BikeLabel.Location = new Point(31, 39);
            BikeLabel.Name = "BikeLabel";
            BikeLabel.Size = new Size(173, 15);
            BikeLabel.TabIndex = 0;
            BikeLabel.Text = "Selecteer uw gewenste bakfiets:";
            // 
            // RentDaysLabel
            // 
            RentDaysLabel.AutoSize = true;
            RentDaysLabel.Location = new Point(31, 116);
            RentDaysLabel.Name = "RentDaysLabel";
            RentDaysLabel.Size = new Size(80, 15);
            RentDaysLabel.TabIndex = 1;
            RentDaysLabel.Text = "Aantal dagen:";
            // 
            // ExtrasLabel
            // 
            ExtrasLabel.AutoSize = true;
            ExtrasLabel.Location = new Point(368, 39);
            ExtrasLabel.Name = "ExtrasLabel";
            ExtrasLabel.Size = new Size(97, 15);
            ExtrasLabel.TabIndex = 2;
            ExtrasLabel.Text = "Extras toevoegen";
            // 
            // CostsPerDayLabel
            // 
            CostsPerDayLabel.AutoSize = true;
            CostsPerDayLabel.Location = new Point(329, 258);
            CostsPerDayLabel.Name = "CostsPerDayLabel";
            CostsPerDayLabel.Size = new Size(205, 15);
            CostsPerDayLabel.TabIndex = 3;
            CostsPerDayLabel.Text = "totale kosten bakfiets en accessoire(s)";
            // 
            // ButtonCalculateCost
            // 
            ButtonCalculateCost.Location = new Point(421, 188);
            ButtonCalculateCost.Name = "ButtonCalculateCost";
            ButtonCalculateCost.Size = new Size(113, 43);
            ButtonCalculateCost.TabIndex = 4;
            ButtonCalculateCost.Text = "Bereken totale kosten";
            ButtonCalculateCost.UseVisualStyleBackColor = true;
            ButtonCalculateCost.Click += ButtonCalculateCost_Click;
            // 
            // RentalDaysNumUpDown
            // 
            RentalDaysNumUpDown.Location = new Point(129, 116);
            RentalDaysNumUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            RentalDaysNumUpDown.Name = "RentalDaysNumUpDown";
            RentalDaysNumUpDown.Size = new Size(119, 23);
            RentalDaysNumUpDown.TabIndex = 2;
            RentalDaysNumUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AccessoiresList
            // 
            AccessoiresList.CheckOnClick = true;
            AccessoiresList.FormattingEnabled = true;
            AccessoiresList.Items.AddRange(new object[] { "Telefoonhouder 5", "Helm 10", "Regenhoes 15", "Babystoel 20" });
            AccessoiresList.Location = new Point(368, 57);
            AccessoiresList.Name = "AccessoiresList";
            AccessoiresList.Size = new Size(166, 94);
            AccessoiresList.TabIndex = 3;
            AccessoiresList.ThreeDCheckBoxes = true;
            // 
            // ChoiceOfBikes
            // 
            ChoiceOfBikes.FormattingEnabled = true;
            ChoiceOfBikes.Items.AddRange(new object[] { "Urban Arrow 4 pers. € 20", "Urban Arrow 6 pers. € 30", "Urban Arrow 4 pers. E-Bike € 40", "Urban Arrow 6 pers. E-Bike € 60" });
            ChoiceOfBikes.Location = new Point(129, 57);
            ChoiceOfBikes.Name = "ChoiceOfBikes";
            ChoiceOfBikes.Size = new Size(190, 23);
            ChoiceOfBikes.TabIndex = 1;
            // 
            // BakfietsVerhuur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 309);
            Controls.Add(ChoiceOfBikes);
            Controls.Add(AccessoiresList);
            Controls.Add(RentalDaysNumUpDown);
            Controls.Add(ButtonCalculateCost);
            Controls.Add(CostsPerDayLabel);
            Controls.Add(ExtrasLabel);
            Controls.Add(RentDaysLabel);
            Controls.Add(BikeLabel);
            Name = "BakfietsVerhuur";
            Text = "BakfietsVerhuur";
            ((System.ComponentModel.ISupportInitialize)RentalDaysNumUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BikeLabel;
        private Label RentDaysLabel;
        private Label ExtrasLabel;
        private Label CostsPerDayLabel;
        private Button ButtonCalculateCost;
        private NumericUpDown RentalDaysNumUpDown;
        private CheckedListBox AccessoiresList;
        private ComboBox ChoiceOfBikes;
    }
}