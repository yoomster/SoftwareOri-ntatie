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
                    PrintMessage("De invoer is niet akkoord, we accepteren alleen cijfers. Probeer het opnieuw");
                    Console.WriteLine();
                }

            } while (is1stNumValid == false || is2ndNumValid == false);
 
           
            Console.WriteLine();

            result = Add(firstNumber, secondNumber);

            PrintMessage($"Uitkomst optellen: {result}");
            if (result < 0)
                PrintMessage("LET OP: is negatief");

            result = Multiply(firstNumber, secondNumber);
            PrintMessage($"Uitkomst vermenigvuldigen: {result}");
            if (result < 0)
                PrintMessage("LET OP: is negatief");

            result = SquareRoot(firstNumber);
            PrintMessage( $"Uitkomst worteltrekken {firstNumber}: {result}");
            if (result < 0)
                PrintMessage("LET OP: is negatief");
            result = SquareRoot(secondNumber);
            PrintMessage($"Uitkomst worteltrekken {secondNumber}: {result}");
            if (result < 0)
                PrintMessage("LET OP: is negatief");

            result = Divide(firstNumber, secondNumber);
            PrintMessage($"Uitkomst delen: {result}");
            if (result < 0)
                PrintMessage("LET OP: is negatief");

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
            return Math.Sqrt(a);
        }
    }
}
