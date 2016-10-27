using System;

namespace Algorithm.DynamicProgramming.PascalsTriangle
{
    public class PascalsTriangle
    {
        static void PascalTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                int c = 1;
                for (int i = 1; i <= line; i++)
                {
                    Console.WriteLine(c);
                    c = c * (line - i) / i;
                }
                Console.WriteLine("\n");
            }
        }

        public static int Main(int input)
        {
            PascalTriangle(input);
            return input;
        }
    }
}
