using System.Security.Cryptography;

namespace _09242
{
    internal class Program
    {
        static void Main(string[] args)
        {
            elso();
        }
        static void elso()
        {
            int n;
            Console.WriteLine("n: ");
            n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            string valasz;
            Random rnd = new Random();
            do
            {
                Console.WriteLine("Véletlen számmal szeretné feltölteni? Y/N");
                valasz = Console.ReadLine();
            } while (valasz.ToUpper() != "Y" && valasz.ToUpper() != "N");


            if (valasz.Equals("Y"))
            {
                for (int i = 0; i < n; i++)
                {
                    x[i] = rnd.Next(1, 101);
                    Console.WriteLine(x[i]);
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"{i + 1}.szám: ");
                    x[i] = int.Parse(Console.ReadLine());
                }
            }

            parosSzamok(x, n);
            monotonNovekvo(x, n);

        }
        static void parosSzamok(int[] x, int n)
        {
            int j = 0;
            while (j < n && (x[j] % 2 != 0))
            {
                j++;
            }

            Console.WriteLine($"n{n} j{j}");
            if (j < n)
            {
                Console.WriteLine("Van");
            }
            else
            {
                Console.WriteLine("Nincs");
            }
        }

        static void monotonNovekvo(int[] x, int n)
        {
            int i = 0;
            while (i < n-1 && x[i + 1] >= x[i])
            {
               i++;
            }
            if (i >= n-1) {
                Console.WriteLine("Monoton növekvő");
                    }
            else {
                Console.WriteLine("Nem monoton növekvő"); 
            }

        }
    }
}
