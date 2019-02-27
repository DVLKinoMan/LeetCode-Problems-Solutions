using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_Two_Integers
{
    class Program
    {
        public static int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == 1)
                return int.MinValue;

            long dividendAbs = Math.Abs((long)dividend);
            long divisorAbs = Math.Abs((long)divisor);

            int result = 0;
            while (dividendAbs >= divisorAbs)
            {
                long y = divisorAbs;
                int count = 1;
                while (dividendAbs >= (y << 1))
                {
                    y <<= 1;
                    count <<= 1;
                }
                dividendAbs -= y;
                result += count;
            }

            if (result < 0)
                return int.MaxValue;

            if (dividend < 0 ^ divisor < 0)
            {
                int temp = result;
                result -= temp;
                result -= temp;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Divide(-2147483648,
- 1);
        }
    }
}
