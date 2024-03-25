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

            //int add = a + b;
            //int substract = a - b;
            //int multiply = a * b;

            Add(10, 5);

            Console.ReadLine();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
