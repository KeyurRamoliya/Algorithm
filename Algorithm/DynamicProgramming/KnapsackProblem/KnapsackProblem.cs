using System;

namespace Algorithm.DynamicProgramming.KnapsackProblem
{
    public class KnapsackProblem
    {
        private static int Knapsack(int w, int[] weight, int[] value, int n)
        {
            int i;
            int[,] k = new int[n + 1, w + 1];
            for (i = 0; i <= n; i++)
            {
                int b;
                for (b = 0; b <= w; b++)
                {
                    if (i==0 || b==0)
                    {
                        k[i, b] = 0;
                    }
                    else if (weight[i - 1] <= b)
                    {
                        k[i, b] = Math.Max(value[i - 1] + k[i - 1, b - weight[i - 1]], k[i - 1, b]);
                    }
                    else
                    {
                        k[i, b] = k[i - 1, b];
                    }
                }
            }
            return k[n, w];
        }

        public static int Main(int nItems, int[] weights, int[] values)
        {
            int n = values.Length;
            return Knapsack(nItems, weights, values, n);
        }
    }
}
