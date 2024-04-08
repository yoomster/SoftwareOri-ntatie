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
            label3 = new Label();
            label4 = new Label();
            ButtonCalculateCost = new Button();
            RentDays = new NumericUpDown();
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)RentDays).BeginInit();
            SuspendLayout();
            // 
            // BikeLabel
            // 
            BikeLabel.AutoSize = true;
            BikeLabel.Location = new Point(61, 46);
            BikeLabel.Name = "BikeLabel";
            BikeLabel.Size = new Size(173, 15);
            BikeLabel.TabIndex = 0;
            BikeLabel.Text = "Selecteer uw gewenste bakfiets:";
            // 
            // RentDaysLabel
            // 
            RentDaysLabel.AutoSize = true;
            RentDaysLabel.Location = new Point(61, 123);
            RentDaysLabel.Name = "RentDaysLabel";
            RentDaysLabel.Size = new Size(80, 15);
            RentDaysLabel.TabIndex = 1;
            RentDaysLabel.Text = "Aantal dagen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 57);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Extras toevoegen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 329);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // ButtonCalculateCost
            // 
            ButtonCalculateCost.Location = new Point(492, 301);
            ButtonCalculateCost.Name = "ButtonCalculateCost";
            ButtonCalculateCost.Size = new Size(113, 43);
            ButtonCalculateCost.TabIndex = 4;
            ButtonCalculateCost.Text = "Bereken totale kosten";
            ButtonCalculateCost.UseVisualStyleBackColor = true;
            // 
            // RentDays
            // 
            RentDays.Location = new Point(159, 123);
            RentDays.Name = "RentDays";
            RentDays.Size = new Size(119, 23);
            RentDays.TabIndex = 5;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Regendak € 15", "Babystoeltje € 20", "Smartphonehouder € 5", "Kaarthouder € 5", "Helm € 10" });
            checkedListBox1.Location = new Point(465, 75);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(166, 130);
            checkedListBox1.TabIndex = 6;
            // 
            // BakfietsVerhuur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(RentDays);
            Controls.Add(ButtonCalculateCost);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RentDaysLabel);
            Controls.Add(BikeLabel);
            Name = "BakfietsVerhuur";
            Text = "BakfietsVerhuur";
            ((System.ComponentModel.ISupportInitialize)RentDays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BikeLabel;
        private Label RentDaysLabel;
        private Label label3;
        private Label label4;
        private Button ButtonCalculateCost;
        private NumericUpDown RentDays;
        private CheckedListBox checkedListBox1;
    }
}