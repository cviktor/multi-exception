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
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;

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
                    //felhasználói hiba üzenet
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
                finally
                {
                    Console.WriteLine("Köszönöm hogy a programot használtad");
                }
            }

            throw new Exception("asdasd");

            Console.ReadKey();
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs unhandledExceptionEventArgs)
        {
            Console.WriteLine("Nem kezel kivétel");
        }

        static int MyParse(string text)
        {
            try
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (!char.IsDigit(text[i]))
                    {
                        ThrowParseException(text[i]);
                    }
                }

                return int.Parse(text); //biztos működni fog
            }
            finally
            {
                Console.WriteLine("Csak finally");
            }
            //catch (ParseException e)
            //{
            //    //saját naplózás
            //    Console.WriteLine("Parse hiba történt. Eredeti szöveg: " + text);
            //    //throw e; NEM JÓ mert újra beállítja a StackTracet
            //    throw;
            //}
        }

        static void ThrowParseException(char c)
        {
            throw new ParseException(c, "Nem szám karakter");
        }

    }
}
