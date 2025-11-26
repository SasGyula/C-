


using System.Data;

namespace _1105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> x = new List<int>();
            x = beolvas();
            List<int> primE = new List<int>();
            primE = kivalogatas(x);
            kiir(primE);
        }

        private static void kiir(List<int> primE)
        {
            for (int i = 0; i < primE.Count; i++)
            {
                Console.WriteLine(primE[i]);
            }
        }

        private static List<int> kivalogatas(List<int> x)
        {
            List<int> s = new List<int>();
            for (int i = 0; i < x.Count; i++)
            {
                if (primE(x[i]))
                {
                    s.Add(x[i]);
                }
            }
            return s;
        }

        private static bool primE(int a)
        {
            if (a < 2) return false;
            for (int j = 2; j <= Math.Sqrt(a); j++)
            {
                if (a % j == 0)
                    return false;
            }
            return true;
        }

        private static List<int> beolvas()
        {
            int n;
            do
            {
                Console.Error.WriteLine("n: ");

            } while (!int.TryParse(Console.ReadLine(), out n) && n <= 0);
            List<int> s = new List<int>();
            for(int i = 0; i<n; i++)
            {
                Console.Error.WriteLine($"{i+1}: ");
                s.Add(int.Parse(Console.ReadLine()));
            }
            return s;
        }
    }
}
