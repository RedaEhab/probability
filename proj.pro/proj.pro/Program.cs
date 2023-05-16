using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj.pro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter The Number Of Items : ");
            n = int.Parse(Console.ReadLine());
            double[] A = new double[n];
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("The Number  " + ((i + 1)));
                A[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(A);
            Console.WriteLine("The Numbers Is : ");

            foreach (double x in A)
            {
                Console.WriteLine(x + "\t");
            }

            int a = (n + 1) / 2;
            double median1 = A[a - 1]; // odd num

            int c = n / 2;
            int b = ((n / 2) + 1);
            double median2 = (A[b - 1] + A[c - 1]) / 2; // even num

            if (n % 2 == 0)
            {
                Console.WriteLine("\n" + "The Value of The Median = " + median2);
            }
            else
            {
                Console.WriteLine("\n" + "The Value Of The Median = " + median1);
            }

            for (i = 0; A[i] == A[i + 1]; i++)
            {
                int mode = (int)A[i];
                Console.WriteLine("\n" + "The Value Of the Mode = " + mode);
            }

            double range = A[n - 1] - A[0];
            Console.WriteLine("\n" + "The value Of The Range = " + range);

            int q1 = (int)Math.Ceiling(n * 0.25) - 1;
            double Q1 = A[q1];
            Console.WriteLine("\n" + "The Value Of The Frist Quartile = " + Q1);

            int q3 = (int)Math.Floor(n * 0.75) - 1;
            double Q3 = A[q3];
            Console.WriteLine("\n" + "The Value of The Third Quartile = " + Q3);

            int p90 = (int)Math.Ceiling(n * 0.9) - 1;
            double P90 = A[p90];
            Console.WriteLine("\n" + "The Value Of The P90 :" + P90);

            double iq = Q3 - Q1;
            Console.WriteLine("\n" + "The Value Of The Interquartile = " + iq);

            double u = Q3 + (1.5 * iq);
            Console.WriteLine("\n" + "The Value Of The Upper Boundaries = " + u);

            double l = Q1 - (1.5 * iq);
            Console.WriteLine("\n" + "The Value Of The Lower Boundaries = " + l);

            if (A[n - 1] < u)
            {
                Console.WriteLine("\n" + "The Input Value is not Outlier");
            }
            else
            {
                Console.WriteLine("\n" + "The Input Value is Outlier");
            }
        }
    }
}
