using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot");
            int x = 0;

            while (x < 3)
            {
                try
                {
                    string line = Console.ReadLine();
                    int number = MyParse(line);
                    Console.WriteLine("A szám 10szerese: " + number * 10);
                    x = 3;
                }
                catch
                {
                    Console.WriteLine("Hiba történt");
                    x++;
                }
            }
            

            Console.ReadKey();
        }

        static int MyParse(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                {
                    throw new Exception("Hibás karakter " + text[i]);
                }
            }

            return int.Parse(text); //biztos működni fog
        }

    }
}
