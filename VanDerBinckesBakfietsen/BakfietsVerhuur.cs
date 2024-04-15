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
        public List<int> IndexAddedExtras { get; set; } = new List<int>();

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

        private void AccessoiresList_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexAddedExtras.Clear();

            for (int i = 0; i < AccessoiresList.Items.Count; i++)
            {
                if (AccessoiresList.GetItemChecked(i))
                {
                    IndexAddedExtras.Add(i);
                }
            }
            CalculateAccessoiresCost();
            CalculateTotalDayCost();
        }

        private void CalculateAccessoiresCost()
        {
            int accessoiresCost = 0;

            foreach (var index in IndexAddedExtras)
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

            MyBikeOrder.SetDailyExtrasCost(accessoiresCost);
        }

        private void CalculateTotalDayCost()
        {
            CostsPerDayLabel.Text = MyBikeOrder.PrintDailyCostTotal();
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            StartDatePicker.MinDate = DateTime.Now.Date;

            ReturnDatePicker.MinDate = StartDatePicker.Value.AddDays(1);

            CalculateTotalNumberOfRentDays();
        }

        private void ReturnDatePicker_ValueChanged_1(object sender, EventArgs e)
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
            TotalCostLabel.Text = MyBikeOrder.PrintTotalCost();
        }

    }
}

public class BikeOrder
{
    private int DailyBikeCost { get; set; } = 20;
    private int DailyExtrasCost { get; set; }
    public int RentDayCount { get; set; }

    public void SetBikeCost(int bikeCost)
    {
        DailyBikeCost = bikeCost;
    }
    public int ReadBikeCost()
    {
        return DailyBikeCost;
    }

    public void SetDailyExtrasCost(int cost)
    {
        DailyExtrasCost = cost;
    }

    public int ReadExtrasCost()
    { 
        return DailyExtrasCost; 
    }

    public int CalculateDailyTotal() => DailyBikeCost + DailyExtrasCost;
    

    public string PrintDailyCostTotal()
    {
        return $"Kosten per dag zijn € {DailyBikeCost + DailyExtrasCost}";
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