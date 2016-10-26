namespace Algorithm.DynamicProgramming.MaximumSubarray
{
    public class MaximumSubarray
    {
        private static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static int MaxSubArray(int[] input, int n)
        {
            int max = input[0];
            int currentMax = input[0];
            for (int i = 1; i < n; i++)
            {
                currentMax = Max(input[i], currentMax + input[i]);
                max = Max(max, currentMax);
            }
            return max;
        }

        public static int Main(int[] input)
        {
            int n = input.Length;
            return MaxSubArray(input, n);
        }
    }
}
