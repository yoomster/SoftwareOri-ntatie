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
            double firstNumber;
            double secondNumber;
            double result;
            bool is1stNumValid;
            bool is2ndNumValid;


            PrintMessage("Welkom bij de calculatie app");

            do
            {
                PrintMessage("Vul een getal in en druk op enter: ");
                is1stNumValid = double.TryParse(Console.ReadLine(), out firstNumber);

                PrintMessage("Vul nog een getal in en druk opnieuw op enter: ");
                is2ndNumValid = double.TryParse(Console.ReadLine(), out secondNumber);

                if (is1stNumValid == false || is2ndNumValid == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("De invoer is niet akkoord, we accepteren alleen cijfers. Probeer het opnieuw");
                    Console.WriteLine();
                }

            } while (is1stNumValid == false || is2ndNumValid == false);
 
           
            Console.WriteLine();

            //Als de uitkomst onder de nul is laat je dit duidelijk zien,
            //bijvoorbeeld door er achter de tekst ‘LET OP: is negatief’ te zetten.


            //vertel gebruiker hoeveel je krijgt als je de getallen optelt
            result = Add(firstNumber, secondNumber);

            Console.WriteLine($"Uitkomst optellen: {result}");
            if (result < 0)
                Console.WriteLine("LET OP: is negatief");

            //en als je de getallen vermenigvuldigt
            result = Multiply(firstNumber, secondNumber);
            Console.WriteLine($"Uitkomst vermenigvuldigen: {result}");


            //door worteltrekken
            result = SquareRoot(firstNumber);
            Console.WriteLine( $"Uitkomst worteltrekken {firstNumber}: {result}");
            result = SquareRoot(secondNumber);
            Console.WriteLine($"Uitkomst worteltrekken {secondNumber}: {result}");

            //en door te delen
            result = Divide(firstNumber, secondNumber);
            Console.WriteLine($"Uitkomst delen: {result}");

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
