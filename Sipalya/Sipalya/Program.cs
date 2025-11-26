


namespace Sipalya
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int napdb, palyadb;
            int[,] meres;
            (napdb, palyadb, meres) = beolvas();
            bool van1, van2;
            int ind1, ind2;
            (van1, ind1) = a_feladat(napdb, palyadb, meres);
            (van2, ind2) = b_feladat(napdb, palyadb, meres);
            Console.WriteLine("#");
            Console.WriteLine(ind1);
            Console.WriteLine("#");
            Console.WriteLine(ind2);
            Console.WriteLine("#");
            Console.WriteLine("#");
        }

        private static (bool van2, int ind2) b_feladat(int napdb, int palyadb, int[,] meres)
        {
            int ind = 0;
            bool van = false;
            for (int i = 0; i < napdb; i++)
            {
                if (van && meres[i, 1] < 50)
                {
                    if (meres[i,1] > meres[ind, 1])
                    {
                        ind = i;
                    }
                }
                else
                {
                    van = true;
                    ind = i;
                }
            }
            return (van, ind);
        }

        private static (bool van1, int ind2) a_feladat(int napdb, int palyadb, int[,] meres)
        {
            int ind = 0;
            bool van = false;
            while (!(van) && ind < palyadb)
            {
                if (meres[1, ind] > 50)
                {
                    van = true;
                }
                else
                {
                    ind++;
                }
            }
            return (van, ind);
        }

        private static (int napdb, int palyadb, int[,] meres) beolvas()
        {
            string[] sv = Console.ReadLine().Split();
            int n = int.Parse(sv[0]);
            int m = int.Parse(sv[1]);
            int[,] meres = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] ssv = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    meres[i, j] = int.Parse(ssv[j]);
                }

            }
            return (n, m, meres);
        }
    }
}
