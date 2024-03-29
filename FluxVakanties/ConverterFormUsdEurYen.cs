using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxVakanties
{
    public partial class ConverterFormUsdEurYen : Form
    {
        public ConverterFormUsdEurYen()
        {
            InitializeComponent();
        }

        //$ USD
        //¥ JPY

        private void DropDownValutaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check YEN of USD selected as currency
            if (DropDownValutaBox.SelectedItem.ToString() == "¥")
            {
                ExchangeRateLabel.Text = "Koers: 1 euro = ¥ ";
                ExchangeRateNumericUpDown.Value = 165;
            }
            else if (DropDownValutaBox.SelectedItem.ToString() == "$")
            {
                ExchangeRateLabel.Text = "Koers: 1 euro = $ ";
                ExchangeRateNumericUpDown.Value = 2;
            }
        }

        private void ConvertToYenOrDollarButton_Click(object sender, EventArgs e)
        {
            //tekst in de tekstvakken omzetten naar nr
            string euroText = EuroTextBox.Text;
            bool tryConvert = decimal.TryParse(euroText, out decimal euros);

            //Voeg een controle toe op de invoer van bedragen
            //bij ongeldige invoer, duidelijke foutmelding + niets berekenen
            if (tryConvert == false)
            {
                MessageBox.Show("FOUTE INVOER! alleen cijfers toegestaan");
                EuroTextBox.Text = "0";
            }
            //bij geldig invoer, doe berekening 

            //Euro’s omrekenen naar dollars-  gebruik ingestelde koers
            decimal exchangeRate = ExchangeRateNumericUpDown.Value;
            decimal euroToDollar = euros * exchangeRate;

            //convert weer naar text
            //toon dollars in de rechter TextBox
            DollarTextBox.Text = Convert.ToString(euroToDollar);
        }

        private void ConvertToEuroButton_Click(object sender, EventArgs e)
        {
            //tekst in de tekstvakken omzetten naar nr
            string dollarText = DollarTextBox.Text;
            bool tryConvert = decimal.TryParse(dollarText, out decimal dollars);

            //Voeg een controle toe op de invoer van bedragen
            //bij ongeldige invoer, duidelijke foutmelding + niets berekenen
            if (tryConvert == false)
            {
                MessageBox.Show("FOUTE INVOER! alleen cijfers toegestaan");
                DollarTextBox.Text = "0";
            }
            
            //bij geldig invoer, doe berekening 

            //reken dollars om naar Euro’s -  gebruik ingestelde koers
            decimal exchangeRate = ExchangeRateNumericUpDown.Value;
            decimal dollarToEuro = dollars / exchangeRate;

            //convert weer naar text
            //toon Euro’s in de linker TextBox in text
            string euro = Convert.ToString(dollarToEuro);
            EuroTextBox.Text = euro;
        }
    }
}
