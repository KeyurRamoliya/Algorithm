namespace Algorithm.DynamicProgramming.Fibonacci
{
    public class Fibonacci
    {
        public static int Main(int limit)
        {
            int result = 0, a = 0, b = 1;
            for (var i = 0; i <= limit; i++)
            {
                var temp = a + b;
                result = temp;
                a = b;
                b = temp;
            }
            return result;
        }
    }
}
