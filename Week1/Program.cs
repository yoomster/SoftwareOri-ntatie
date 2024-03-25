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

            Console.Write( "What is your age: ");
            string ageNr = Console.ReadLine();
            int.TryParse(ageNr, out int age);
            Console.WriteLine(age + 2);

            //-------------------------------
            Console.WriteLine(Add(10, 5));
            Console.WriteLine(Add(79650, 450));

            Console.WriteLine(Subtract(10, 5));
            Console.WriteLine(Subtract(79650, 24400));

            Console.WriteLine(Multiply(10, 5));
            Console.WriteLine(Multiply(120, 120));

            Console.WriteLine(Divide(10, 3));
            Console.WriteLine(Divide(79650, 11));


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
    }
}
