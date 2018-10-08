using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot");
            string line = Console.ReadLine();
            double number = double.Parse(line);
            Console.WriteLine("A szám 10szerese: " + number * 10);
            Console.ReadKey();
        }

        
    }
}
