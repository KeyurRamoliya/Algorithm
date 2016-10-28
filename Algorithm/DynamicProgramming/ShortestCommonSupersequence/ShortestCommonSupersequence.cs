namespace Algorithm.DynamicProgramming.ShortestCommonSupersequence
{
    public class ShortestCommonSupersequence
    {
        private static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        
        private static int Lcs(string x, string y, int m, int n)
        {
            var l = new int[m + 1, n + 1];
            for (var i = 0; i <= m; i++)
            {
                for (var j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0) l[i, j] = 0;
                    else if (x[i - 1] == y[j - 1]) l[i, j] = l[i - 1, j - 1] + 1;
                    else l[i, j] = Max(l[i - 1, j], l[i, j - 1]);
                }
            }
            return l[m, n];
        }

        private static int Scs(string x, string y)
        {
            int m = x.Length, n = y.Length;
            int l = Lcs(x, y, m, n);
            return m + n - l;
        }

        public static int Main(string x, string y)
        {
            return Scs(x, y);
        }
    }
}
