using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloJij
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string fullName = NameBox.Text;
            string firstName= string.Empty;
            string lastName= string.Empty;
            string message = string.Empty;

            int positionOfSpace = fullName.IndexOf(" ");

            if (positionOfSpace == -1)
            {
                message = "Invoer incorrect, vul aub uw voor- en achternaam in";
            }
            else
            {
                firstName = fullName.Substring(0, positionOfSpace);
                lastName = fullName.Substring(positionOfSpace + 1);

                if (!WomanButton.Checked && !ManButton.Checked)
                {
                    message = "Invoer incorrect, vink uw geslacht aan aub.";
                }
                else if (WomanButton.Checked)
                {
                    message = $"Hallo mejuffrouw {lastName}";
                }
                else if (ManButton.Checked)
                {
                    message = $"Hallo mijnheer {lastName}";
                }
            }

            Console.WriteLine(firstName, lastName);

            MessageBox.Show(message);




            //Breid opdracht 3 uit zodat hij bij invoer als “Jan de Graaf” de tekst
            //“Hallo mijnheer Graaf, de” laat zien door gebruik te maken van de string-methode LastIndexOf.
            //Breidt opdracht 3 uit zodat invoer als “ jan janssen“
            //(met veel spaties aan het begin, aan het eind en er tussen) nog steeds werkt.
            //Dus uitvoer is “Hallo mijnheer Janssen” (zonder extra spaties).
        }
    }
}
