namespace Algorithm.DynamicProgramming.CatalanNumber
{
    public class CatalanNumber
    {
        public static int Main(int number)
        {
            int result = 0;
            if (number <= 1) return 1;
            for (int i = 0; i < number; i++)
            {
                result += Main(i)*Main(number - i - 1);
            }
            return result;
        }
    }
}
