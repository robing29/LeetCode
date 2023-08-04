using System.Security.Cryptography.X509Certificates;

namespace Problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TwoSum(new int[] { -3, 4, 3, 90 }, 0);
            TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            TwoSum(new int[] { 3, 2, 4}, 6);
            TwoSum(new int[] { 3, 3 }, 6);
            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> result = nums.ToList();
            int[] ints = new int[2];
            foreach (int item in result)
            {
                ints[0] = item;
                if (result.Where(x => x + item == target && x != item).ToList().Count() > 0)
                {
                    ints[1] = result.Where(x => x + item == target && x != item).First();
                    break;
                }

            }
            if (ints[1] + ints[0] != target)
            {
                ints[1] = (target / 2);
                ints[0] = (target / 2);
            }
            ints[0] = nums.ToList().IndexOf(ints[0]);
            ints[1] = nums.ToList().LastIndexOf(ints[1]);

            return ints;
        }
    }
}