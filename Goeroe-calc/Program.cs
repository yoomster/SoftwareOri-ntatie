using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goeroe_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vraag om getal 1
            Console.WriteLine("Vul een getal in en druk op enter: ");
            int.TryParse(Console.ReadLine(), out int number);

            //vraag om getal 2
            Console.WriteLine("Vul nog een getal in en druk opnieuw op enter: ");
            int.TryParse(Console.ReadLine(), out int numberTwo);

            //vertel gebruiker hoeveel je krijgt als je de getallen optelt
            Console.WriteLine("Door de opgegeven getallen op te tellen, krijg je " + (number + numberTwo));

            //maar ook hoeveel je krijgt als je de getallen vermenigvuldigt.
            Console.WriteLine("Door dezelfde opgegeven getallen te vermenigvuldigen, krijg je " + (number * numberTwo));


            Console.ReadLine();
        }
    }
}
