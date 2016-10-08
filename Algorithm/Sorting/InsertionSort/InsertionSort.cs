namespace Algorithm.Sorting.InsertionSort
{
    public class InsertionSort
    {
        public static void SortInsertion(int[] input, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int x = input[i];
                int j = i - 1;
                while (j >= 0 && input[j] > x)
                {
                    input[j + 1] = input[j];
                    j = j - 1;
                }
                input[j + 1] = x;
            }
        }

        public static int[] Main(int[] input)
        {
            SortInsertion(input, input.Length);
            return input;
        }
    }
}
