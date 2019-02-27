using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Element
{
    class Program
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            foreach(var num in nums.Where(num=>num!=val))
            {
                nums[i] = num;
                i++;
            }

            return i;
        }

        //Not mine
        public static int RemoveElementWithLessMemory(int[] nums, int val)
        {
            int i = 0;
            int j = nums.Length - 1;
            while (i <= j)
            {
                if (nums[i] != val)
                {
                    i++;
                }
                else
                {
                    nums[i] = nums[j];
                    j--;
                }
            }

            return j + 1;
        }

        static void Main(string[] args)
        {
            RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
        }
    }
}
