namespace Algorithm.Sorting.PigeonholeSort
{
    public class PigeonholeSort
    {
        private static void SortPigeonhole(int[] input, int n)
        {
            int min = input[0], max = input[n];
            for (int i = 1; i < n; i++)
            {
                if (input[i] < min) min = input[i];
                if (input[i] > max) max = input[i];
            }
            int range = max - min + 1;
            int[] holes = new int[range];

            for (int i = 0; i < n; i++)
            {
                holes[input[i] - min] = input[i];
            }
            int index = 0;

            for (int i = 0; i < range; i++)
            {
                foreach (var value in holes)
                {
                    input[index++] = value;
                }
            }
        }

        public static int[] Main(int[] input)
        {
            SortPigeonhole(input, input.Length);
            return input;
        }
    }
}
