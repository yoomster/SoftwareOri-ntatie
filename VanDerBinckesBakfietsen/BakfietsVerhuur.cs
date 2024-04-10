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

        BakfietsModel urbanArrow1 = new BakfietsModel { Name = "Urban Arrow 01" };

        public int RentDays { get; set; }



        private void ButtonCalculateCost_Click(object sender, EventArgs e)
        {
            int costBike = ChosenBikeCost();
            List<int> IndexAddedAccessoires = SaveAccessoiresToList();
            int costAccessoires = CalculateAccessoiresCost(IndexAddedAccessoires);
            int totalCost = (costBike * RentDays) + (costAccessoires * RentDays);

            CostsPerDayLabel.Text = $"Kosten per dag € {costBike + costAccessoires}";

            TotalCostLabel.Text = $"Totale kosten bakfiets en bovenstaande accessoire(s) zijn € {totalCost}";

        }

        private int ChosenBikeCost()
        {
            string bikeChoice = ChoiceOfBikes.Text;
            int bikeCost = 0;

            if (bikeChoice == "Urban Arrow 4 pers. € 20")
                bikeCost = 20;
            else if (bikeChoice == "Urban Arrow 6 pers. € 30")
                bikeCost = 30;
            else if (bikeChoice == "Urban Arrow 4 pers. E-Bike € 40")
                bikeCost = 40;
            else if (bikeChoice == "Urban Arrow 6 pers. E-Bike € 60")
                bikeCost = 60;
            return bikeCost;
        }

        private List<int> SaveAccessoiresToList()
        {
            List<int> indexCheckedItems = new List<int>();

            for (int i = 0; i < AccessoiresList.Items.Count; i++)
            {
                if (AccessoiresList.GetItemChecked(i))
                {
                    indexCheckedItems.Add(i);
                }
            }

            return indexCheckedItems;
        }

        private static int CalculateAccessoiresCost(List<int> indexCheckedItems)
        {
            int costExtras = 0;

            foreach (var item in indexCheckedItems)
            {
                if (item == 0)
                    costExtras += 5;
                else if (item == 1)
                    costExtras += 10;
                else if (item == 2)
                    costExtras += 15;
                else if (item == 3)
                    costExtras += 20;
            }

            return costExtras;
        }


        private void ReturnDatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime startDate = StartDatePicker.Value;
            DateTime returnDate = ReturnDatePicker.Value;

 
            TimeSpan difference = returnDate - startDate;

            int totalDays = (int)Math.Ceiling(difference.TotalDays);

            if (totalDays <= 0)
            {
                MessageBox.Show("LET OP: is negatief");
                ButtonCalculateCost.Enabled = false;
            }
            else
            {
                totalDaysLabel.Text = $"Totaal aantal dagen {totalDays}";
                ButtonCalculateCost.Enabled = true;
            }

            RentDays = totalDays;

        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            StartDatePicker.MinDate = DateTime.Now.Date;

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

