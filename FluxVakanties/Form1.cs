using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxVakanties
{
    public partial class EurToUsdConverter : Form
    {
        public EurToUsdConverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EuroButton_Click(object sender, EventArgs e)
        {
            //Voeg een controle toe op de invoer van bedragen

            //tekst in de tekstvakken omzetten naar nr
            string dollarText = DollarTextBox.Text;
            bool tryConvert = decimal.TryParse(dollarText, out decimal dollars);

            //bij geldig invoer, doe berekening 
            //bij ongeldige invoer, duidelijke foutmelding + niets berekenen
            if (tryConvert == false)
            {
                MessageBox.Show("FOUT!");
                DollarTextBox.Text = "0";
            }

            //reken dollars om naar Euro’s -  gebruik ingestelde koers
            decimal exchangeRate = ExchangeRateNumericUpDown.Value;
            decimal dollarToEuro = dollars / exchangeRate;

            //toon Euro’s in de linker TextBox in text
            string euro = Convert.ToString(dollarToEuro);
            EuroTextBox.Text = euro;
        }

        private void DollarButton_Click(object sender, EventArgs e)
        {
            string euroText = EuroTextBox.Text;
            bool tryConvert = decimal.TryParse(euroText, out decimal euros);

            //bij ongeldige invoer, duidelijke foutmelding + niets berekenen
            if (tryConvert == false)
            {
                MessageBox.Show("FOUT!");
                EuroTextBox.Text = "0";
            }

            //Euro’s omrekenen naar dollars-  gebruik ingestelde koers
            decimal exchangeRate = ExchangeRateNumericUpDown.Value;
            decimal euroToDollar = euros * exchangeRate;

            //convert dec weer naar text
            //toon dollars in de rechter TextBox
            DollarTextBox.Text = Convert.ToString(euroToDollar);
        }

    }
}
