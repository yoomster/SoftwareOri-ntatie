using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string message = string.Empty;
            List<string> nameElements = NameBox.Text.Split(' ').ToList();

            if (nameElements.Count < 2)
            {
                message = "Vul aub uw voor- en achternaam in";
            }

            nameElements.RemoveAt(0);
            StringBuilder stringBuilder = new StringBuilder();
            string lastName = string.Empty;

            lastName = CreateLastName(nameElements, stringBuilder);

            if (!WomanButton.Checked && !ManButton.Checked)
            {
                message = "invoer incorrect, vink uw geslacht aan aub.";
            }
            else if (WomanButton.Checked)
            {
                message = $"Hallo mejuffrouw {lastName}";
            }
            else if (ManButton.Checked)
            {
                message = $"Hallo mijnheer {lastName}";
            }

            MessageBox.Show(message);
        }

        private static string CreateLastName(List<string> nameElements, StringBuilder stringBuilder)
        {
            string lastName;
            foreach (string element in nameElements)
            {
                stringBuilder.Append($"{element} ");
            }
            lastName = stringBuilder.ToString();
            return lastName;
        }
    }
}
