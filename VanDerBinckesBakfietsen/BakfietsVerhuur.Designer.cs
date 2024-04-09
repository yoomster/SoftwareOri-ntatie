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
            StartDatePicker = new DateTimePicker();
            RentDateLlabel = new Label();
            StartLabel = new Label();
            label1 = new Label();
            ReturnDatePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)RentalDaysNumUpDown).BeginInit();
            SuspendLayout();
            // 
            // BikeLabel
            // 
            BikeLabel.AutoSize = true;
            BikeLabel.Font = new Font("Segoe UI", 12F);
            BikeLabel.Location = new Point(98, 31);
            BikeLabel.Name = "BikeLabel";
            BikeLabel.Size = new Size(226, 21);
            BikeLabel.TabIndex = 0;
            BikeLabel.Text = "Selecteer uw gewenste bakfiets";
            // 
            // RentDaysLabel
            // 
            RentDaysLabel.AutoSize = true;
            RentDaysLabel.Font = new Font("Segoe UI", 12F);
            RentDaysLabel.Location = new Point(98, 261);
            RentDaysLabel.Name = "RentDaysLabel";
            RentDaysLabel.Size = new Size(104, 21);
            RentDaysLabel.TabIndex = 1;
            RentDaysLabel.Text = "Aantal dagen:";
            // 
            // ExtrasLabel
            // 
            ExtrasLabel.AutoSize = true;
            ExtrasLabel.Font = new Font("Segoe UI", 12F);
            ExtrasLabel.Location = new Point(98, 111);
            ExtrasLabel.Name = "ExtrasLabel";
            ExtrasLabel.Size = new Size(216, 21);
            ExtrasLabel.TabIndex = 2;
            ExtrasLabel.Text = "Extras toevoegen (kosten p/d)";
            // 
            // CostsPerDayLabel
            // 
            CostsPerDayLabel.AutoSize = true;
            CostsPerDayLabel.Font = new Font("Segoe UI", 12F);
            CostsPerDayLabel.Location = new Point(56, 392);
            CostsPerDayLabel.Name = "CostsPerDayLabel";
            CostsPerDayLabel.Size = new Size(271, 21);
            CostsPerDayLabel.TabIndex = 3;
            CostsPerDayLabel.Text = "Totale kosten bakfiets en accessoire(s)";
            // 
            // ButtonCalculateCost
            // 
            ButtonCalculateCost.Font = new Font("Segoe UI", 12F);
            ButtonCalculateCost.Location = new Point(98, 325);
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
            RentalDaysNumUpDown.Location = new Point(202, 261);
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
            AccessoiresList.Location = new Point(98, 144);
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
            ChoiceOfBikes.Location = new Point(98, 64);
            ChoiceOfBikes.Name = "ChoiceOfBikes";
            ChoiceOfBikes.Size = new Size(190, 29);
            ChoiceOfBikes.TabIndex = 1;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Location = new Point(388, 133);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(253, 23);
            StartDatePicker.TabIndex = 5;
            StartDatePicker.ValueChanged += StartDatePicker_ValueChanged;
            // 
            // RentDateLlabel
            // 
            RentDateLlabel.AutoSize = true;
            RentDateLlabel.Location = new Point(388, 85);
            RentDateLlabel.Name = "RentDateLlabel";
            RentDateLlabel.Size = new Size(72, 15);
            RentDateLlabel.TabIndex = 7;
            RentDateLlabel.Text = "Huur datum";
            // 
            // StartLabel
            // 
            StartLabel.AutoSize = true;
            StartLabel.Location = new Point(407, 112);
            StartLabel.Name = "StartLabel";
            StartLabel.Size = new Size(31, 15);
            StartLabel.TabIndex = 8;
            StartLabel.Text = "Start";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 183);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 9;
            label1.Text = "Eind";
            // 
            // ReturnDatePicker
            // 
            ReturnDatePicker.Location = new Point(388, 221);
            ReturnDatePicker.Name = "ReturnDatePicker";
            ReturnDatePicker.Size = new Size(253, 23);
            ReturnDatePicker.TabIndex = 10;
            ReturnDatePicker.ValueChanged += ReturnDatePicker_ValueChanged_1;
            // 
            // BakfietsVerhuur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 479);
            Controls.Add(ReturnDatePicker);
            Controls.Add(label1);
            Controls.Add(StartLabel);
            Controls.Add(RentDateLlabel);
            Controls.Add(StartDatePicker);
            Controls.Add(ChoiceOfBikes);
            Controls.Add(AccessoiresList);
            Controls.Add(RentalDaysNumUpDown);
            Controls.Add(ButtonCalculateCost);
            Controls.Add(CostsPerDayLabel);
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
        private Label CostsPerDayLabel;
        private Button ButtonCalculateCost;
        private NumericUpDown RentalDaysNumUpDown;
        private CheckedListBox AccessoiresList;
        private ComboBox ChoiceOfBikes;
        private DateTimePicker StartDatePicker;
        private Label RentDateLlabel;
        private Label StartLabel;
        private Label label1;
        private DateTimePicker ReturnDatePicker;
    }
}