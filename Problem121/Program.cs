namespace Problem121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public int MaxProfit(int[] prices)
        {

            int l = 0;
            int r = 1;
            int maxProfit = 0;
            while (r < prices.Length)
            {
                if (prices[l] < prices[r])
                {
                    maxProfit = Math.Max(prices[r] - prices[l], maxProfit);
                    r++;
                }
                else
                {
                    l = r;
                    r = l + 1;
                }
            }
            return maxProfit;

        }
    }
}