namespace _0924
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n: ");
            n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("%d.szám: " i+1);
                x[i] = int.TryParse(Console.ReadLine());
            }
        }
    }
}
