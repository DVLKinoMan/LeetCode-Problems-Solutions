using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        public static int RemoveDuplicates(int[] nums)
        {
            var set = new HashSet<int>(nums);
            int i = 0;
            foreach (var s in set.Reverse())
            {
                nums[i] = s;
                i++;
            }
            return set.Count();
        }
        static void Main(string[] args)
        {
            RemoveDuplicates(new int[] { 1, 1, 2 });
        }
    }
}
