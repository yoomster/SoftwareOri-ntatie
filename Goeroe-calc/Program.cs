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
            PrintMessage("Vul een getal in en druk op enter: ");
            double.TryParse(Console.ReadLine(), out double number);

            //vraag om getal 2
            Console.WriteLine("Vul nog een getal in en druk opnieuw op enter: ");
            double.TryParse(Console.ReadLine(), out double numberTwo);

            //vertel gebruiker hoeveel je krijgt als je de getallen optelt
            Console.WriteLine("Uitkomst optellen: " + (number + numberTwo));

            //en als je de getallen vermenigvuldigt
            Console.WriteLine("Uitkomst vermenigvuldigen: " + (number * numberTwo));

            //door worteltrekken
            SquareRoot(number);


            Console.WriteLine("Uitkomst worteltrekken: " + (number * numberTwo));


            //en door te delen
            Console.WriteLine("Uitkomst delen: " + (number / numberTwo));



            Console.ReadLine();
        }

        public static void PrintMessage(string a)
        {
            Console.WriteLine(a);
        }

        public static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
       
        public static void Multiply(double a, double b)
        {
            Console.WriteLine(a * b);
        }
        

        public static double SquareRoot(double a)
        {
            double output = Math.Sqrt(a);

            return output;
        }
    }
}
