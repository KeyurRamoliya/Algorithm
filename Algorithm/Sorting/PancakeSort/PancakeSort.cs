namespace Algorithm.Sorting.PancakeSort
{
    public class PancakeSort
    {
        private static void SortPancake(int[] input, int n)
        {
            for (var bottom = n - 1; bottom > 0; bottom--)
            {
                var index = bottom;
                var maxIndex = input[bottom];
                int i;
                for (i = bottom - 1; i >= 0; i--)
                {
                    if (input[i] > maxIndex)
                    {
                        maxIndex = input[i];
                        index = i;
                    }
                }
                if (index == bottom) continue;
                var temp = new int[n];
                var j = 0;
                for (i = bottom; i > index; i--,j++)
                {
                    temp[j] = input[i];
                }
                for (i = 0; i < index; i++, j++)
                {
                    temp[j] = input[i];
                }
                if (temp.Length > j) temp[j] = input[index];
                for (i = 0; i <= bottom; i++)
                {
                    input[i] = temp[i];
                }
            }
        }

        public static int[] Main(int[] input)
        {
            SortPancake(input, input.Length);
            return input;
        }
    }
}
