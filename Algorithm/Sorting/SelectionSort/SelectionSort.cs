using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorting.SelectionSort
{
    public class SelectionSort
    {
        private static void SortSelection(int[] input, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                var minId = i;
                int j;
                for (j = i + 1; j < n; j++)
                {
                    if (input[j] < input[minId]) minId = j;
                }
                var temp = input[minId];
                input[minId] = input[i];
                input[i] = temp;
            }
        }

        public static int[] Main(int[] input)
        {
            SortSelection(input, input.Length);
            return input;
        }
    }
}
