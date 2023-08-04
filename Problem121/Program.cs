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
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i+1; j < prices.Length; j++)
                {
                    int temp = prices[j] - prices[i]; //Szenario für einen Verkauf an dem Tag
                    maxProfit = temp > maxProfit ? temp : maxProfit; //Tag an dem man verkauft - Tag an dem man verkauft
                }
            }
            return maxProfit;


            //Sicherstellen, dass Profit wirklich positiv ist
            //Buy before sell

        }
    }
}