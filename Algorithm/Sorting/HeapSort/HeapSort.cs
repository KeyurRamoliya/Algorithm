namespace Algorithm.Sorting.HeapSort
{
    public class HeapSort
    {
        public static void Heapify(int[] input, int n, int i)
        {
            int largest = i;
            int l = i + 1;
            int r = i + 2;

            if (l < n && input[l] > input[largest])
                largest = l;

            if (r < n && input[r] > input[largest])
                largest = r;

            if (largest != i)
            {
                var temp = input[i];
                input[i] = input[largest];
                input[largest] = temp;
                Heapify(input, n, largest);
            }
        }

        public static void SortHeap(int[] input, int n)
        {
            for (var i = n - 1; i >= 0; i--)
            {
                Heapify(input, n, i);
            }
            for (int j = n - 1; j >= 0; j--)
            {
                var temp = input[0];
                input[0] = input[j];
                input[j] = temp;
                Heapify(input, j, 0);
            }
        }

        public static int[] Main(int[] input)
        {
            SortHeap(input, input.Length);
            return input;
        }
    }
}
