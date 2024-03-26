using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variabelen
            //string welcome = "Hi, welcome to this app";
            //Console.WriteLine(welcome);

            //Console.Write( "What is your age: ");
            //string ageNr = Console.ReadLine();
            //int.TryParse(ageNr, out int age);
            //Console.WriteLine($"your age in 15 years will be: {age + 15}" );

            ////-------------------------------
            //Console.WriteLine(Add(10, 5));
            //Console.WriteLine(Add(79650, 450));

            //Console.WriteLine(Subtract(10, 5));
            //Console.WriteLine(Subtract(79650, 24400));

            //Console.WriteLine(Multiply(10, 5));
            //Console.WriteLine(Multiply(120, 120));

            //double multiplied = Divide(10, 5);
            //Console.WriteLine(multiplied);
            //Console.WriteLine(Divide(10, 3));
            //Console.WriteLine(Divide(79650, 11));


            //RechtToeRechtAan();
            //AlWandelend();


            Console.ReadLine();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static void RechtToeRechtAan()
        {
            //double output = (100 * 0.7) - (25 * 0.6);

            //double output = 18.0 / 5.0;

            double output = 100 / 30;

            Console.WriteLine(output);

        }

        public static void AlWandelend()
        {
            double afstand = 20;

            for (int i = 1; i <= 5; i++)
            {
                afstand = afstand - (afstand / 4);
                Console.WriteLine($"resterende afstand na rustpunt {i} is {afstand}");
            }

        }

    }
}
