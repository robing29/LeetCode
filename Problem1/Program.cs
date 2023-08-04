using System.Data;
using System.Collections;
using System.Numerics;

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
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            int[] ints = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(target - nums[i]))
                {
                    ints[0] = keyValuePairs[(target-nums[i])];
                    ints[1] = i;
                    break;
                    
                } else
                {
                    if (keyValuePairs.ContainsKey(nums[i]) == false) keyValuePairs.Add(nums[i], i);
                }
            }
            return ints;
        }
    }
}