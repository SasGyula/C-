using System;
using System.Buffers;
using System.Collections.Generic;
namespace ParosSzamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            List<int> kim = new List<int>();

            szamok = beolvas("add meg");
            kim = kivalogat(szamok);
            kiir(szamok, "Eredeti:");
            kiir(kim, "Feltötött:");
        }

        private static void kiir(List<int> kim, String sz)
        {
            Console.WriteLine(sz);
            for (int i = 0; i < kim.Count; i++)
            {
                Console.Write(kim[i] + " ");
            }
            Console.WriteLine();
        }

        private static List<int> kivalogat(List<int> szamok)
        {
            List<int> sv = new List<int>();
            for (int i = 0; i < szamok.Count; i++)
            {
                if (paros(szamok[i]))
                {
                    sv.Add(szamok[i]);
                }
            }
            return sv;
        }

        private static List<int> beolvas(String asd)
        {
            List<int> sv =  new List<int>();
            Console.WriteLine(asd);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Random rnd = new Random();
                int ssv = rnd.Next(1, 101);
                sv.Add(ssv);
            }
            return sv;
        }
        private static bool paros(int szam)
        {
            return szam % 2 == 0;
        }
    }
}
