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
            string welcome = "Hi, welcome to this app";
            Console.WriteLine(welcome);

            Console.Write("What is your age: ");
            string ageNr = Console.ReadLine();
            int.TryParse(ageNr, out int age);
            Console.WriteLine($"your age in 15 years will be: {age + 15}");

            //-------------------------------
            Add(10, 5);
            Add(79650, 450);

            Subtract(10, 5);
            Subtract(79650, 24400);

            Multiply(10, 5);
            Multiply(120, 120);

            Divide(10, 5);
            Divide(10, 3);
            Divide(79650, 11);

            Console.WriteLine();

            Console.WriteLine("Recht Toe Recht Aan opdracht");
            RechtToeRechtAan();

            Console.WriteLine();

            Console.WriteLine("Al wandelend opdracht");
            AlWandelend();

            Console.ReadLine();
        }

        static void Add(int a, int b)
        {
            Console.WriteLine( $"optellen {a} plus {b}: { a + b}");
        }
        static void Add(double a, double b)
        {
            Console.WriteLine($"optellen {a} plus {b}: {a + b}");
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine($"aftrekken {a} min {b}: {a - b}");
        }
        static void Subtract(double a, double b)
        {
            Console.WriteLine($"aftrekken {a} min {b}: {a - b}");
        }
        static void Multiply(double a, double b)
        {
            Console.WriteLine($"verminigvuldigen {a} keer {b}: {a * b}");
        }
        static void Divide(double a, double b)
        {
            Console.WriteLine($"delen {a} gedeeld door {b}: {a / b}");
        }

        static void RechtToeRechtAan()
        {
            //double output = (100 * 0.7) - (25 * 0.6);

            //double output = 18.0 / 5.0;

            double output = 100 / 30;

            Console.WriteLine(output);

        }

        static void AlWandelend()
        {
            double afstand = 20;

            for (int i = 1; i <= 5; i++)
            {
                afstand -= (afstand / 4);
                Console.WriteLine($"resterende afstand na rustpunt {i} is {afstand}");
            }

        }

    }
}
