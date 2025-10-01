using System;
namespace Homerseklet
{
    internal class Program
    {
        struct Thom
        {
            public int mine, maxe;
        }
        static void Main(string[] args)
        {
            int n;
            //kimeneti vált
            Console.Error.WriteLine("n: ");
            n = int.Parse(Console.ReadLine());
            Thom[] x = new Thom[n];
            for (int i = 0; i < n; i++)
            {
                string sv = Console.ReadLine();
                string[] svt = sv.Split(' ');
                x[i].mine = int.Parse(svt[0]);
                x[i].maxe = int.Parse(svt[1]);
            }
            //feldolgozás
            int db = 0;
            //kiiras
            Console.WriteLine("#");

            Console.WriteLine("#");

            Console.WriteLine("#");
            
            Console.WriteLine("#");
        }
    }
}
