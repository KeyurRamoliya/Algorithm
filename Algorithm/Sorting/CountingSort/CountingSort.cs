using System.Linq;

namespace Algorithm.Sorting.CountingSort
{
    public class CountingSort
    {
        public static void SortCounting(int[] input, int min, int max)
        {
            var count = new int[max - min + 1];
            var z = 0;

            for (var i = 0; i < count.Length; i++)
                count[i] = 0;

            foreach (int i in input)
                count[i - min]++;

            for (var i = min; i <= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    input[z] = i;
                    ++z;
                }
            }
        }

        public static int[] Main(int[] input)
        {
            SortCounting(input, input.Min(), input.Max());
            return input;
        }
    }
}
