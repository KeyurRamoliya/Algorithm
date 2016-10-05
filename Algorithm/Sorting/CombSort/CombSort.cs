namespace Algorithm.Sorting.CombSort
{
    public class CombSort
    {
        public static int FindGap(int gap)
        {
            gap = gap*10/13;
            if (gap == 9 || gap == 10) gap = 11;
            if (gap < 1) gap = 1;
            return gap;
        }

        public static void SortComb(int[] input, int size)
        {
            int gap = size;
            for (;;)
            {
                gap = FindGap(gap);
                var swap = false;
                for (var i = 0; i < size - gap; i++)
                {
                    var j = i + gap;
                    if (input[i] <= input[j]) continue;
                    var temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    swap = true;
                }
                if (gap == 1 && !swap) break;
            }
        }

        public static int[] Main(int[] input)
        {
            SortComb(input, input.Length);
            return input;
        }
    }
}
