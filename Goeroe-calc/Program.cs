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
            double a;
            double b;
            double uitkomst;
            
            PrintMessage("Welkom bij de calculatie app");

 
            //vraag om getal 1
            PrintMessage("Vul een getal in en druk op enter: ");
            bool checkNr = double.TryParse(Console.ReadLine(), out a);

            //vraag om getal 2
            Console.WriteLine("Vul nog een getal in en druk opnieuw op enter: ");
            bool checkNrTwo = double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine();

            //Als de uitkomst onder de nul is laat je dit duidelijk zien,
            //bijvoorbeeld door er achter de tekst ‘LET OP: is negatief’ te zetten.


            //vertel gebruiker hoeveel je krijgt als je de getallen optelt
            uitkomst = Add(a, b);
            Console.WriteLine($"Uitkomst optellen: {uitkomst}");
            if (uitkomst < 0)
            {
                Console.WriteLine("LET OP: is negatief");
            }

            //en als je de getallen vermenigvuldigt
            uitkomst = Multiply(a, b);
            Console.WriteLine($"Uitkomst vermenigvuldigen: {uitkomst}");

            //door worteltrekken
            uitkomst = SquareRoot(a);
            Console.WriteLine( $"Uitkomst worteltrekken {a}: {uitkomst}");
            uitkomst = SquareRoot(b);
            Console.WriteLine($"Uitkomst worteltrekken {b}: {uitkomst}");

            //en door te delen
            uitkomst = Divide(a, b);
            Console.WriteLine($"Uitkomst delen: {uitkomst}");

            Console.ReadLine();
        }

        public static void PrintMessage(string a)
        {
            Console.WriteLine(a);
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
       
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double SquareRoot(double a)
        {
            double output = Math.Sqrt(a);

            return output;
        }
    }
}
