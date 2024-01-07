using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdza ilość samogłosek we wprowadzonym słowie.");
            Console.Write("Podaj słowo do sprawdzdenia ilości samogłosek: ");
            string slowo = Console.ReadLine();

            Console.WriteLine(IloscSamoglosek(slowo));

            Console.ReadKey();

        }

        static int IloscSamoglosek(string slowo)
        {
            int ilosc = 0;
            slowo = slowo.ToLower();
            foreach (char litera in slowo)
            {
                if ("aeiouy".Contains(litera))
                {
                    ilosc++;
                }
            }
            return ilosc;
        }

    }
}