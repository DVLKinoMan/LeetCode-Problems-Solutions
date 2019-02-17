using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    class Program
    {
        public static bool IsPalindrome(int x)
        {
            string str = x.ToString();
            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(123321));
        }
    }
}
