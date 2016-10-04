namespace Algorithm.Sorting.BubbleSort
{
    public class BubbleSort
    {
        public static void SortBubble(int[] input)
        {
            for (var i = input.Length - 1; i >= 0; i--)
            {
                for (var j = input.Length - 1 - 1; j >= 0; j--)
                {
                    if (input[j] <= input[j + 1]) continue;
                    var temp = input[j + 1];
                    input[j + 1] = input[j];
                    input[j] = temp;
                }
            }
        }

        public static int[] Main(int[] input)
        {
            SortBubble(input);
            return input;
        }
    }
}
