using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanDerBinckesBakfietsen
{
    public partial class BakfietsVerhuur : Form
    {
        public BakfietsVerhuur()
        {
            InitializeComponent();
        }
        //List<string> accessoires = new List<string> ;
        //BakfietsModel urbanArrow1 = new BakfietsModel { Name = "Urban Arrow 01" };

        public int RentDays { get; set; }
        public int BikeCost { get; set; }
        public int AccessoiresCost { get; set; }
        public int DayCost { get; set; }
        public List<int> IndexAccessoiresAdded { get; set; } = new List<int>();



        private void ButtonCalculateCost_Click(object sender, EventArgs e)
        {
            //List<int> IndexAddedAccessoires = SaveAccessoiresToList();
            int totalCost = (BikeCost * RentDays) + (AccessoiresCost * RentDays);

            TotalCostLabel.Text = $"Totale kosten bakfiets en bovenstaande accessoire(s) zijn € {totalCost}";
        }
        private void CalculateTotalDayCost()
        {
            CalculateBikeCost();

            DayCost = BikeCost += AccessoiresCost;
        }
        private int CalculateBikeCost()
        {
            BikeCost = 0;
            string bikeChoice = ChoiceOfBikes.Text;

            if (bikeChoice == "Urban Arrow 4 pers. € 20")
                BikeCost = 20;
            else if (bikeChoice == "Urban Arrow 6 pers. € 30")
                BikeCost = 30;
            else if (bikeChoice == "Urban Arrow 4 pers. E-Bike € 40")
                BikeCost = 40;
            else if (bikeChoice == "Urban Arrow 6 pers. E-Bike € 60")
                BikeCost = 60;
            return BikeCost;
        }


        private void CalculateAccessoiresCost(List<int> indexCheckedItems)
        {
            AccessoiresCost = 0;

            foreach (var index in indexCheckedItems)
            {
                if (index == 0)
                    AccessoiresCost += 5;
                else if (index == 1)
                    AccessoiresCost += 10;
                else if (index == 2)
                    AccessoiresCost += 15;
                else if (index == 3)
                    AccessoiresCost += 20;
            }
        }
        private void AccessoiresList_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexAccessoiresAdded.Clear();

            for (int i = 0; i < AccessoiresList.Items.Count; i++)
            {
                if (AccessoiresList.GetItemChecked(i))
                {
                    IndexAccessoiresAdded.Add(i);
                }
            }
            CalculateAccessoiresCost(IndexAccessoiresAdded);
            CalculateTotalDayCost();


            CostsPerDayLabel.Text = $"Kosten per dag € BikeCost: {BikeCost}  ass:{AccessoiresCost} daycost: {DayCost}"; //doesnt show bike cost
        }




        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            StartDatePicker.MinDate = DateTime.Now.Date;
        }

        private void ReturnDatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            ReturnDatePicker.MinDate = DateTime.Now.Date.AddDays(1);
        }

        private void ButtonConfirmDays_Click(object sender, EventArgs e)
        {
            CalculateTotalNumberOfRentDays();
        }

        private void CalculateTotalNumberOfRentDays()
        {
            DateTime startDate = StartDatePicker.Value;
            DateTime returnDate = ReturnDatePicker.Value;

            TimeSpan difference = returnDate - startDate;

            RentDays = (int)Math.Ceiling(difference.TotalDays);

            if (RentDays <= 0)
            {
                MessageBox.Show("Error, foutieve invoer");
            }
            else
            {
                totalDaysLabel.Text = $"Totaal aantal dagen {RentDays}";
                ButtonCalculateCost.Enabled = true;
            }
        }
    }

    public class BakfietsModel()
    {
        public string Name { get; set; }
        public int NrOfPassengers { get; set; }
        public int Price { get; set; }
        public FietsAccessoiresModel Accessoires { get; set; }
    }

    public class FietsAccessoiresModel()
    {
        public string Name { get; set; }
        public int Price { get; set; }

        //Telefoonhouder 5
        //Helm 10
        //Regenhoes 15
        //Babystoel 20
    }
}

