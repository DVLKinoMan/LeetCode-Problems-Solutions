using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Sum
{
    class Program
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j != i + 1)
                        while (j < nums.Length - 1 && nums[j] == nums[j - 1])
                            j++;
                    int begin = j + 1, end = nums.Length - 1;
                    while (begin < end)
                    {
                        int sum = nums[i] + nums[j] + nums[begin] + nums[end];
                        if (sum == target)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[begin], nums[end] });
                            begin++;
                            end--;
                            while (begin < end && nums[begin] == nums[begin - 1])
                                begin++;
                            while (begin < end && nums[end] == nums[end + 1])
                                end--;
                        }
                        else if (sum < target)
                        {
                            begin++;
                            while (begin < end && nums[begin] == nums[begin - 1])
                                begin++;
                        }
                        else
                        {
                            end--;
                            while (begin < end && nums[end] == nums[end + 1])
                                end--;
                        }
                    }
                }
                while (i < nums.Length -1  && nums[i] == nums[i + 1])
                    i++;
            }

            return result;
        }
        static void Main(string[] args)
        {
            var result = FourSum(new int[] { -1, -5, -5, -3, 2, 5, 0, 4 }, -7);
            Console.ReadLine();
        }
    }
}
