using System;
using System.Data;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int n, int m, int[,] x) = beolvas();
            bool van = eldont(n, m, x);
            kiirmatrix(x);
            Console.WriteLine($"{van}");
        }

        private static void kiirmatrix(int[,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for(int j = 0;j < x.GetLength(1); j++)
                {
                    if(j % x.GetLength(1) == 0)
                    {
                        Console.Write("\n");
                    }
                    Console.Write($"{x[i, j]} ");
                }
            }
            Console.WriteLine();
        }

        private static (int, int ,int[,]) beolvas() {
            Random rnd = new Random();
            int n = szamBekeres("N: ");
            int m = szamBekeres("M: ");
            int[,] s = new int[n, m];
            for (int i = 0; i < s.GetLength(0); i++)
            {
                for (int j = 0; j < s.GetLength(1); j++)
                {
                    s[i, j] = rnd.Next(1, 101);
                }

            }
            return (n, m, s);
        }
        private static int szamBekeres(string asd)
        {
            int s = 0;
            Console.WriteLine(asd);
            do
            {
            }
            while (!(s >= 1 && s <= 100) && (int.TryParse(Console.ReadLine(), out s)));
            return s;
        }
        private static bool eldont(int n, int m, int[,] x)
        {
            int sor = 0;
            while (sor < n && !vanbenneprim(sor, m, x))
            {
                sor++;
            }
            return sor < n;
        }

        private static bool vanbenneprim(int sor, int m, int[,] x)
        {
            int oszlop = 0;
            while (oszlop < m && !prime(x[sor, oszlop]))
            {
                oszlop++;
            }
            return oszlop < m;
        }

        private static bool prime(int v)
        {
            if (v < 2) return false;
            for (int i = 2; i <= Math.Sqrt(v); i++)
            {
                if (v % i == 0) return false;
            }
            return true;
        }
    }
}
