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
            TotalCostLabel = new Label();
            ButtonCalculateCost = new Button();
            RentalDaysNumUpDown = new NumericUpDown();
            AccessoiresList = new CheckedListBox();
            ChoiceOfBikes = new ComboBox();
            StartDatePicker = new DateTimePicker();
            RentDateLlabel = new Label();
            StartLabel = new Label();
            label1 = new Label();
            ReturnDatePicker = new DateTimePicker();
            totalDaysLabel = new Label();
            CostsPerDayLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)RentalDaysNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // BikeLabel
            // 
            BikeLabel.AutoSize = true;
            BikeLabel.Font = new Font("Segoe UI", 12F);
            BikeLabel.Location = new Point(56, 26);
            BikeLabel.Name = "BikeLabel";
            BikeLabel.Size = new Size(226, 21);
            BikeLabel.TabIndex = 0;
            BikeLabel.Text = "Selecteer uw gewenste bakfiets";
            // 
            // RentDaysLabel
            // 
            RentDaysLabel.AutoSize = true;
            RentDaysLabel.Font = new Font("Segoe UI", 12F);
            RentDaysLabel.Location = new Point(375, 282);
            RentDaysLabel.Name = "RentDaysLabel";
            RentDaysLabel.Size = new Size(104, 21);
            RentDaysLabel.TabIndex = 1;
            RentDaysLabel.Text = "Aantal dagen:";
            // 
            // ExtrasLabel
            // 
            ExtrasLabel.AutoSize = true;
            ExtrasLabel.Font = new Font("Segoe UI", 12F);
            ExtrasLabel.Location = new Point(56, 106);
            ExtrasLabel.Name = "ExtrasLabel";
            ExtrasLabel.Size = new Size(216, 21);
            ExtrasLabel.TabIndex = 2;
            ExtrasLabel.Text = "Extras toevoegen (kosten p/d)";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 12F);
            TotalCostLabel.Location = new Point(56, 392);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(271, 21);
            TotalCostLabel.TabIndex = 3;
            TotalCostLabel.Text = "Totale kosten bakfiets en accessoire(s)";
            // 
            // ButtonCalculateCost
            // 
            ButtonCalculateCost.Enabled = false;
            ButtonCalculateCost.Font = new Font("Segoe UI", 12F);
            ButtonCalculateCost.Location = new Point(257, 346);
            ButtonCalculateCost.Name = "ButtonCalculateCost";
            ButtonCalculateCost.Size = new Size(190, 43);
            ButtonCalculateCost.TabIndex = 4;
            ButtonCalculateCost.Text = "Bereken totale kosten";
            ButtonCalculateCost.UseVisualStyleBackColor = true;
            ButtonCalculateCost.Click += ButtonCalculateCost_Click;
            // 
            // RentalDaysNumUpDown
            // 
            RentalDaysNumUpDown.Font = new Font("Segoe UI", 12F);
            RentalDaysNumUpDown.Location = new Point(479, 282);
            RentalDaysNumUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            RentalDaysNumUpDown.Name = "RentalDaysNumUpDown";
            RentalDaysNumUpDown.Size = new Size(86, 29);
            RentalDaysNumUpDown.TabIndex = 2;
            RentalDaysNumUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AccessoiresList
            // 
            AccessoiresList.CheckOnClick = true;
            AccessoiresList.Font = new Font("Segoe UI", 12F);
            AccessoiresList.FormattingEnabled = true;
            AccessoiresList.Items.AddRange(new object[] { "Telefoonhouder 5", "Helm 10", "Regenhoes 15", "Babystoel 20" });
            AccessoiresList.Location = new Point(56, 139);
            AccessoiresList.Name = "AccessoiresList";
            AccessoiresList.Size = new Size(190, 100);
            AccessoiresList.TabIndex = 3;
            AccessoiresList.ThreeDCheckBoxes = true;
            // 
            // ChoiceOfBikes
            // 
            ChoiceOfBikes.Font = new Font("Segoe UI", 12F);
            ChoiceOfBikes.FormattingEnabled = true;
            ChoiceOfBikes.Items.AddRange(new object[] { "Urban Arrow 4 pers. € 20", "Urban Arrow 6 pers. € 30", "Urban Arrow 4 pers. E-Bike € 40", "Urban Arrow 6 pers. E-Bike € 60" });
            ChoiceOfBikes.Location = new Point(56, 59);
            ChoiceOfBikes.Name = "ChoiceOfBikes";
            ChoiceOfBikes.Size = new Size(202, 29);
            ChoiceOfBikes.TabIndex = 1;
            ChoiceOfBikes.Text = "Urban Arrow 4 pers. € 20";
            // 
            // StartDatePicker
            // 
            StartDatePicker.Font = new Font("Segoe UI", 12F);
            StartDatePicker.Location = new Point(375, 88);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(253, 29);
            StartDatePicker.TabIndex = 5;
            // 
            // RentDateLlabel
            // 
            RentDateLlabel.AutoSize = true;
            RentDateLlabel.Font = new Font("Segoe UI", 12F);
            RentDateLlabel.Location = new Point(375, 31);
            RentDateLlabel.Name = "RentDateLlabel";
            RentDateLlabel.Size = new Size(94, 21);
            RentDateLlabel.TabIndex = 7;
            RentDateLlabel.Text = "Huur datum";
            // 
            // StartLabel
            // 
            StartLabel.AutoSize = true;
            StartLabel.Font = new Font("Segoe UI", 12F);
            StartLabel.Location = new Point(392, 59);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new Size(42, 21);
            StartLabel.TabIndex = 8;
            StartLabel.Text = "Start";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(394, 138);
            label1.Name = "label1";
            label1.Size = new Size(40, 21);
            label1.TabIndex = 9;
            label1.Text = "Eind";
            // 
            // ReturnDatePicker
            // 
            ReturnDatePicker.Font = new Font("Segoe UI", 12F);
            ReturnDatePicker.Location = new Point(375, 162);
            ReturnDatePicker.Name = "ReturnDatePicker";
            ReturnDatePicker.Size = new Size(253, 29);
            ReturnDatePicker.TabIndex = 10;
            ReturnDatePicker.ValueChanged += ReturnDatePicker_ValueChanged_1;
            // 
            // totalDaysLabel
            // 
            totalDaysLabel.AutoSize = true;
            totalDaysLabel.Font = new Font("Segoe UI", 12F);
            totalDaysLabel.Location = new Point(375, 242);
            totalDaysLabel.Name = "totalDaysLabel";
            totalDaysLabel.Size = new Size(147, 21);
            totalDaysLabel.TabIndex = 11;
            totalDaysLabel.Text = "Totaal aantal dagen ";
            // 
            // CostsPerDayLabel
            // 
            CostsPerDayLabel.AutoSize = true;
            CostsPerDayLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CostsPerDayLabel.Location = new Point(56, 268);
            CostsPerDayLabel.Name = "CostsPerDayLabel";
            CostsPerDayLabel.Size = new Size(114, 21);
            CostsPerDayLabel.TabIndex = 12;
            CostsPerDayLabel.Text = "Kosten per dag";
            // 
            // BakfietsVerhuur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 479);
            Controls.Add(CostsPerDayLabel);
            Controls.Add(totalDaysLabel);
            Controls.Add(ReturnDatePicker);
            Controls.Add(label1);
            Controls.Add(StartLabel);
            Controls.Add(RentDateLlabel);
            Controls.Add(StartDatePicker);
            Controls.Add(ChoiceOfBikes);
            Controls.Add(AccessoiresList);
            Controls.Add(RentalDaysNumUpDown);
            Controls.Add(ButtonCalculateCost);
            Controls.Add(TotalCostLabel);
            Controls.Add(ExtrasLabel);
            Controls.Add(RentDaysLabel);
            Controls.Add(BikeLabel);
            Name = "BakfietsVerhuur";
            Text = "Van der Binckes bakfiets verhuur";
            ((System.ComponentModel.ISupportInitialize)RentalDaysNumUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BikeLabel;
        private Label RentDaysLabel;
        private Label ExtrasLabel;
        private Label TotalCostLabel;
        private Button ButtonCalculateCost;
        private NumericUpDown RentalDaysNumUpDown;
        private CheckedListBox AccessoiresList;
        private ComboBox ChoiceOfBikes;
        private DateTimePicker StartDatePicker;
        private Label RentDateLlabel;
        private Label StartLabel;
        private Label label1;
        private DateTimePicker ReturnDatePicker;
        private Label totalDaysLabel;
        private Label CostsPerDayLabel;
    }
}