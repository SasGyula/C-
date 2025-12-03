using System.Runtime.ConstrainedExecution;

namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szelveny = new int[5];
            int ar;
            int[] nyeremeny = new int[4];
            int[,] szamok = new int[55, 5];
            szelveny = bekeres();
            for(int i = 0; i < szelveny.Length; i++)
            {
                Console.Write(szelveny[i] + " ");
            }
        }
        static int[] bekeres()
        {
            string[] be1 = Console.ReadLine().Split();
            int[] ki1 = new int[be1.Length];
            for (int i = 0; i <be1.Length; i++)
            {
                ki1[i] = int.Parse(be1[i]);
            }
            int ar = int.Parse(Console.ReadLine());
            string[] be2 = Console.ReadLine().Split();
            int[] ki2 = new int[be2.Length];
            for (int i = 0; i < be2.Length; i++)
            {
                ki2[i] = int.Parse(be2[i]);
            }
            string[] be3 = Console.ReadLine().Split();
            int[,] ki3 = new int[55, 5];
            for (int i = 0; i < ki3.Length; i++)
            {
                for (int j = 0; i < ki3[i].Length; i++{

                }
            }
            return ki1;
        }
    }
}
