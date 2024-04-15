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

        public BikeOrder MyBikeOrder { get; set; } = new();
        public List<int> IndexAccessoiresAdded { get; set; } = new List<int>();

        private void ChoiceOfBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bikeChoice = ChoiceOfBikes.Text;

            if (bikeChoice == "Urban Arrow 4 pers. € 20")
                MyBikeOrder.SetBikeCost(20);
            else if (bikeChoice == "Urban Arrow 6 pers. € 30")
                MyBikeOrder.SetBikeCost(30);
            else if (bikeChoice == "Urban Arrow 4 pers. E-Bike € 40")
                MyBikeOrder.SetBikeCost(40);
            else if (bikeChoice == "Urban Arrow 6 pers. E-Bike € 60")
                MyBikeOrder.SetBikeCost(60);
            CalculateTotalDayCost();
        }


        private void CalculateAccessoiresCost(List<int> indexCheckedItems)
        {
            var accessoiresCost = 0;

            foreach (var index in indexCheckedItems)
            {
                if (index == 0)
                    accessoiresCost += 5;
                else if (index == 1)
                    accessoiresCost += 10;
                else if (index == 2)
                    accessoiresCost += 15;
                else if (index == 3)
                    accessoiresCost += 20;
            }

            MyBikeOrder.SetDailyAccessoryCost(accessoiresCost);
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
        }

        private void CalculateTotalDayCost()
        {
            CostsPerDayLabel.Text = MyBikeOrder.PrintDailyCostTotal();
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            StartDatePicker.MinDate = DateTime.Now.Date;

            CalculateTotalNumberOfRentDays();

        }

        private void ReturnDatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            ReturnDatePicker.MinDate = DateTime.Now.Date.AddDays(1);

            CalculateTotalNumberOfRentDays();

        }

        private void ButtonConfirmDays_Click(object sender, EventArgs e)
        {
            CalculateTotalNumberOfRentDays();
        }

        private void CalculateTotalNumberOfRentDays()
        {
            MyBikeOrder.RentDayCount = 0;
            DateTime startDate = StartDatePicker.Value;
            DateTime returnDate = ReturnDatePicker.Value;

            TimeSpan difference = returnDate - startDate;

            MyBikeOrder.RentDayCount = (int)Math.Ceiling(difference.TotalDays);
      
            if (MyBikeOrder.RentDayCount <= 0)
            {
                MessageBox.Show("Error, foutieve invoer");
                ButtonCalculateCost.Enabled = false;

            }
            else
            {
                totalDaysLabel.Text = $"Totaal aantal dagen {MyBikeOrder.RentDayCount}";
                ButtonCalculateCost.Enabled = true;
            }
        }
        private void ButtonCalculateTotalCost_Click(object sender, EventArgs e)
        {
            int totalCost = (MyBikeOrder.ReadBikeCost() * MyBikeOrder.RentDayCount) + (MyBikeOrder.DailyAccessoryCost * MyBikeOrder.RentDayCount);

            TotalCostLabel.Text = MyBikeOrder.PrintTotalCost();

            totalDaysLabel.Text = MyBikeOrder.PrintTotalRentDays();

            CalculateTotalDayCost();

        }

    }
}

public class BikeOrder
{
    private int DailyBikeCost { get; set; } = 20;
    public int DailyAccessoryCost { get; set; }
    public int RentDayCount { get; set; }


    public int ReadBikeCost() 
    {
        return DailyBikeCost;
    }

    public void SetBikeCost(int bikeCost)
    {
        DailyBikeCost = bikeCost;
    }

    public void SetDailyAccessoryCost(int cost)
    {
        DailyAccessoryCost = cost;
    }

    public int CalculateDailyTotal() => DailyBikeCost + DailyAccessoryCost;
    

    public string PrintDailyCostTotal()
    {
        return $"Kosten per dag zijn € {DailyBikeCost + DailyAccessoryCost}";
    }

    public string PrintTotalCost()
    {
        return $"Totale kosten zijn € {CalculateDailyTotal() * RentDayCount}"; ;
    }

    public string PrintTotalRentDays()
    {
        return $"Totaal aantal dagen {RentDayCount}";
    }

}