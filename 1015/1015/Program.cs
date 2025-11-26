namespace _1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());
            int[] mag = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i+1} = ");
                mag[i] = int.Parse(Console.ReadLine());
            }
            bool van;
            int ki = 1;
            while (ki < n && mag[ki] >= mag[ki - 1])
            {
                ki++;
            }
            van = (ki < n);
            if (van)
            {
                Console.WriteLine($" ez a {ki + 1}. diák");
            }
            else
            {
                Console.WriteLine("Nincs");
            }

            int db = 0;
            int[] kim = new int[n];
            for (int i = 1; i < n; ++i)
            {
                if (mag[i] < mag[i - 1])
                {
                    db++;
                    kim[db] = i;
                }
            }
            Console.WriteLine($"{db} van");
            for (int i = 1; i <= db; ++i)
            {
                Console.WriteLine(kim[i] + 1 + " ");
            }
        }
    }
}
