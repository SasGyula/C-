namespace MaxMagassag
{
    internal class Program
    {
        struct Tmag
        {
            public int h;
            public string nev;

        };
        static void Main(string[] args)
        {
            int n;
            string legmnev;
            int ind;
            Console.WriteLine("n: ");
            n = int.Parse(Console.ReadLine());
            Tmag[] x=new Tmag[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}. magasság");
                x[i].h = int.Parse(Console.ReadLine());
                Console.WriteLine($"{i+1}.hely neve");
                x[i].nev = Console.ReadLine();
            }
            //feladat
            ind = 0;
            for (int i = 1; i < n; i++)
            {
                if (x[i].h > x[ind].h)
                {
                    ind = i;
                }
            }
            legmnev = x[ind].nev;

            Console.WriteLine($"A legmagasabb pont a {legmnev}, {x[ind].h}m magas");
        }
    }
}
