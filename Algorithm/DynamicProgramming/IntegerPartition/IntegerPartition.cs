namespace Algorithm.DynamicProgramming.IntegerPartition
{
    public class IntegerPartition
    {
        public static int[,] Result = new int[100,100];

        private static int Partition(int targetNumber, int largestNumber)
        {
            for (int i = 1; i <= targetNumber; i++)
            {
                for (int j = 1; j <= largestNumber; j++)
                {
                    if (i - j < 0)
                    {
                        Result[i, j] = Result[i, j - 1];
                        continue;
                    }
                    Result[i, j] = Result[i, j - 1] + Result[i - j, j];
                }
            }
            return Result[targetNumber, largestNumber];
        }

        public static int Main(int number, int target)
        {
            int i;
            for (i = 0; i <= number; i++)
            {
                Result[i, 0] = 0;
            }
            for (i = 1; i <= target; i++)
            {
                Result[0, i] = 1;
            }
            return Partition(number, target);
        }
    }
}
