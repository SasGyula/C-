using System;
namespace CsoportZHSasGyula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mer = beolvas();
            List<int> melysegek = kivalogat(mer);
            kiir(melysegek);
        }

        private static void kiir(List<int> melysegek)
        {
            for (int i = 0; i <melysegek.Count; i++)
            {
                Console.Write($"{melysegek[i]} ");
            }
        }

        private static List<int> kivalogat(int[] mer)
        {
            List<int> kim = new List<int>();
            int db = 0;
            for (int i = 0;i < mer.Length; i++)
            {
                if (!voltmar(mer[i], i, mer))
                {
                    db++;
                    kim.Add(mer[i]);
                }
            }
            return kim;
        }
        private static bool voltmar(int mi, int ind, int[] miben)
        {

            int j = 0;
            while (j <= ind && mi != miben[j])
            {
                j++;
            }
            return j< ind;
        }


        private static int[] beolvas()
        {
            int n = 0;
            do
            {
                Console.Error.WriteLine("N: ");
            } while (!(n >= 1 && n <= 100) && (int.TryParse(Console.ReadLine(), out n)));
            int[] s= new int[n];
            for (int i = 0; i < s.Length; i++)
            {
                do
                {
                    Console.Error.WriteLine($"{i + 1}: ");
                } while (int.TryParse(Console.ReadLine(), out s[i]) && !(s[i] >= 1 && s[i]<=20));
            }
            return s;
        }
    }
}
