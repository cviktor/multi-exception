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
                catch (ParseException e)
                {
                    Console.WriteLine("A hibás karakterem: " + e.Character);
                    Console.WriteLine(e.ToString());
                    x++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hibás formátum");
                    x++;
                }
                catch //(Exception)
                {
                    Console.WriteLine("Ismeretlen hiba történt");
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
                    throw new ParseException(text[i], "Nem szám karakter");
                }
            }

            return int.Parse(text); //biztos működni fog
        }

    }
}
