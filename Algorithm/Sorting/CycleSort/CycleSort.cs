using System.Linq;

namespace Algorithm.Sorting.CycleSort
{
    public class CycleSort
    {
        public static void SortCycle(int[] input)
        {
            for (var i = 0; i < input.Length; i++)
            {
                var item = input[i];
                var position = i;
                do
                {
                    var k = input.Where((t, j) => position != j && t < item).Count();
                    if (position == k) continue;
                    while (position != k && item == input[k])
                    {
                        k++;
                    }
                    var temp = input[k];
                    input[k] = item;
                    item = temp;
                    position = k;
                } while (position != i);
            }
        }

        public static int[] Main(int[] input)
        {
            SortCycle(input);
            return input;
        }
    }
}
