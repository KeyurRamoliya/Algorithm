namespace Algorithm.Sorting.ShellSort
{
    public class ShellSort
    {
        static void SortShell(int[] input, int n)
        {
            var inc = 3;
            while (inc > 0)
            {
                int i;
                for (i = 0; i < n; i++)
                {
                    var j = i;
                    var temp = input[i];
                    while ((j >= inc) && (input[j - inc] > temp))
                    {
                        input[j] = input[j - inc];
                        j = j - inc;
                    }
                    input[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

        public static int[] Main(int[] input)
        {
            SortShell(input, input.Length);
            return input;
        }
    }
}
