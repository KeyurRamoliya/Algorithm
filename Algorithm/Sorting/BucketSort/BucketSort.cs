using System.Collections.Generic;

namespace Algorithm.Sorting.BucketSort
{
    public class BucketSort
    {
        public static void SortBucket(ref int[] input)
        {
            int minValue = input[0];
            int maxValue = input[0];
            int k = 0;

            for (int i = input.Length - 1; i >= 1; i--)
            {
                if (input[i] > maxValue) maxValue = input[i];
                if (input[i] < minValue) minValue = input[i];
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = bucket.Length - 1; i >= 0; i--)
            {
                bucket[i] = new List<int>();
            }

            foreach (int i in input)
            {
                bucket[i - minValue].Add(i);
            }

            foreach (List<int> b in bucket)
            {
                if (b.Count > 0)
                {
                    foreach (int t in b)
                    {
                        input[k] = t;
                        k++;
                    }
                }
            }
        }

        public static int[] Main(int[] input)
        {
            SortBucket(ref input);
            return input;
        }
    }
}
