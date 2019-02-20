using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Sum_Closest
{
    class Program
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            if (nums.Length < 3)
                return 0;

            Array.Sort(nums);
            int result = nums.Take(3).Sum();
            for(int i=0; i<nums.Length; i++)
            {
                int begin = i + 1, end = nums.Length - 1;
                while (begin < end)
                {
                    int sum = nums[i] + nums[begin] + nums[end];
                    if (Math.Abs(result - target) > Math.Abs(sum - target))
                        result = sum;

                    if (result == target)
                        return result;

                    if (sum < target)
                        begin++;
                    else
                        end--;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            ThreeSumClosest(new int[] { -1, 0, 1, 1, 55}, 3);
            Console.ReadKey();
        }
    }
}
