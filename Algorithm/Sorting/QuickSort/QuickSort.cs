namespace Algorithm.Sorting.QuickSort
{
    public class QuickSort
    {
        private static int Partition(int[] input, int low, int high)
        {
            var pivot = input[high];
            var i = low - 1;
            for (var j = low; j <= high - 1; j++)
            {
                if (input[j] <= pivot)
                {
                    i++;
                    var temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                }
            }
            var tmp = input[i + 1];
            input[i + 1] = input[high];
            input[high] = tmp;
            return (i + 1);
        }

        private static void SortQuick(int[] input, int low, int high)
        {
            while (true)
            {
                if (low < high)
                {
                    var pi = Partition(input, low, high);
                    SortQuick(input, low, pi - 1);
                    low = pi + 1;
                    continue;
                }
                break;
            }
        }

        public static int[] Main(int[] input)
        {
            SortQuick(input, 0, input.Length - 1);
            return input;
        }
    }
}
