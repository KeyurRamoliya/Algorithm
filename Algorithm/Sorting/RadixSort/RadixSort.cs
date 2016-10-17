using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Sorting.RadixSort
{
    public class RadixSort
    {
        private static void SortRadix(int[] input, int n)
        {
            var temp = new int[n];

            for (var shift = 31; shift > -1; --shift)
            {
                var j = 0;
                for (var i = 0; i < n; ++i)
                {
                    var move = input[i] << shift >= 0;

                    if (shift == 0 ? !move : move)
                        input[i - j] = input[i];
                    else
                        temp[j++] = input[i];
                }
                Array.Copy(temp, 0, input, n - j, j);
            }
        }

        public static int[] Main(int[] input)
        {
            SortRadix(input, input.Length);
            return input;
        }
    }
}
