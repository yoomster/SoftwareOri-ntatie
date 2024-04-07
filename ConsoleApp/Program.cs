using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String manipulatie (in C#)

            Console.WriteLine("abcdef".Substring(1, 1));  
            Console.WriteLine("abcdef".Substring(3, 2));
            Console.WriteLine("abcdef".Substring(0, 6));
            Console.WriteLine("abcdef".Substring(0, 7));
            Console.WriteLine("abcdef".Substring(7, 1));


            Console.ReadLine();
        }
    }
}
