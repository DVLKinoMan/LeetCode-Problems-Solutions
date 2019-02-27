using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_strStr__
{
    class Program
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;

            int len = haystack.Length - needle.Length;
            for (int i = 0; i <= len; i++)
            {
                int j = i;
                foreach (var ch in needle)
                {
                    if (ch != haystack[j])
                        break;
                    j++;
                }

                if (j - i != needle.Length)
                    continue;

                return i;
            }

            return -1;
        }

        static void Main(string[] args)
        {
        }
    }
}
