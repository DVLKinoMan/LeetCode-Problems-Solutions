using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    class Program
    {
        public static int Reverse(int x)
        {
            string str = x.ToString();
            str = string.Concat(str.Where(ch => ch != '-').Reverse());
            int result;
            int.TryParse(x < 0 ? '-' + str : str, out result);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(1534236469));
            Console.ReadKey();
        }
    }
}
