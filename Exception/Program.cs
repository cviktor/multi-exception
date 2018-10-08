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

            try
            {
                string line = Console.ReadLine();
                int number = MyParse(line);
                Console.WriteLine("A szám 10szerese: " + number * 10);
            }
            catch
            {
                Console.WriteLine("Hiba történt");
            }

            Console.ReadKey();
        }

        static int MyParse(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                {
                    throw new System.Exception("Hibás karakter " + text[i]);
                }
            }

            return int.Parse(text); //biztos működni fog
        }

    }
}
