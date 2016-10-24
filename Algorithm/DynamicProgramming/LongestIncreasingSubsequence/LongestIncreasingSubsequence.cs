namespace Algorithm.DynamicProgramming.LongestIncreasingSubsequence
{
    public class LongestIncreasingSubsequence
    {
        private static int Lis(int[] input, int n)
        {
            int[] lis = new int[n];
            int max = 0;
            for(int i = 0; i < n; i++)
            {
                lis[i] = 1;
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[i] > input[j] && lis[i] < lis[j] + 1)
                        lis[i] = lis[j] + 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (max < lis[i])
                    max = lis[i];
            }
            return max;
        }

        public static int Main(int[] input)
        {
            int n = input.Length;
            return Lis(input, n);
        }
    }
}