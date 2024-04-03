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
            //voor- en achternaam En vinkt een radiobutton geslacht
            //
            //programma toont MessageBox met de tekst “Hallo mejuffrouw Jansen” of “Hallo mijnheer Jansen”
            //afhankelijk van de ingevoerde tekst en geselecteerde radiobutton. 
            //De gebruiker voert Voornaam +Achternaam in, maar de MessageBox toont de tekst zonder de voornaam.
            //Invoer als “Jan de Graaf” en radiobutton geslacht “Man“ levert het bericht “Hallo mijnheer de Graaf” op.


        }
    }
}
