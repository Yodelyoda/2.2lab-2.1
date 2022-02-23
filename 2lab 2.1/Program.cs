using System;

namespace _2lab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, j;
            double S;
            Console.WriteLine("N = ");
            N = Convert.ToInt64(Console.Read());
            S = 0;
            j = 2;
            while (j <= N)
            {
                S += (j * (N - j)) / (Math.Pow(j, 2) + (Math.Pow(N - j, 2)));
                j++;
            }
            Console.WriteLine("S = ",S);
            S = 0;
            j = 2;
            do
            {
                S += (j * (N - j)) / (Math.Pow(j, 2) + (Math.Pow(N - j, 2)));
                j++;
            } while (j <= N);
            Console.WriteLine("S = ", S);
            S = 0;
            for (j = 2; j <= N; j++)
            {
                S += (j * (N - j)) / (Math.Pow(j, 2) + (Math.Pow(N - j, 2)));
            }
            Console.WriteLine("S = ", S);
            S = 0;
            for (j = N; j >= 2; j--)
            {
                S += (j * (N - j)) / (Math.Pow(j, 2) + (Math.Pow(N - j, 2)));
            }
            Console.WriteLine("S = ", S);
            Console.ReadKey();

        }
    }
}
