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
        List<string> accessoires = new List<string> ;

        Bakfiets urbanArrow1 = new Bakfiets { Name = "Urban Arrow 01" };

        private void ButtonCalculateCost_Click(object sender, EventArgs e)
        {
            int numberOfdays = (int)RentalDaysNumUpDown.Value;
            int costBike = ChosenBikeCost();
            List<int> indexExtraItems = SaveAccessoiresToList();
            int costAccessoires = CalculateAccessoiresCost(indexExtraItems);
            int totalCost = (costBike * numberOfdays) + (costAccessoires * numberOfdays);

            CostsPerDayLabel.Text = $"Totale kosten bakfiets en accessoire(s) is € {totalCost}";

        }

        private int ChosenBikeCost()
        {
            string bikeChoice = ChoiceOfBikes.Text;
            int bikeCost = 0;

            if (string.IsNullOrEmpty(bikeChoice))
                Console.WriteLine("De invoer is niet akkoord, selecteer 1");
            else if (bikeChoice == "Urban Arrow 4 pers. € 20")
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

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = StartDatePicker.Value;
        }

        private void ReturnDatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime returnDate = ReturnDatePicker.Value;

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

