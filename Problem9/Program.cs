


internal class Program
{
    private static void Main(string[] args)
    {
        IsPalindrome(123);
    }
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        string y = x.ToString();
        int i = 0;
        int k = y.Length - 1;

        bool wahr = true;
        while ((k - i) > 0)
        {
            if (y[i] != y[k])
            {
                return false;
            }
            i++;
            k--;
        }
        return wahr;
    }
}