using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Roman
{
    class Program
    {
        public static string IntToRoman(int num)
        {
            StringBuilder result = new StringBuilder();
            var romanNumbers = new string[] { "I", "V", "X", "L", "C", "D", "M" };

            var decimalNumbers = new List<int> { 1, 5, 10, 50, 100, 500, 1000 };

            var amounts = new List<int> { 1, 10, 100, 1000 };
            var amountsInRoman = new string[] { "I", "X", "C", "M" };

            for(int i= amounts.Count-1; i>=0; i--)
            {
                int div = num / amounts[i];
                if (div > 0)
                {
                    int index = decimalNumbers.IndexOf(div * amounts[i] + amounts[i]);
                    if (index >= 0)
                        result.Append(amountsInRoman[i] + romanNumbers[index]);
                    else
                    {
                        int index2 = decimalNumbers.IndexOf(5 * amounts[i]);
                        if (div >= 5)
                            result.Append(romanNumbers[index2] + string.Concat(Enumerable.Repeat(amountsInRoman[i], div - 5)));
                        else result.Append(string.Concat(Enumerable.Repeat(amountsInRoman[i], div)));
                    }
                    num -= div * amounts[i];
                }
            }

            return result.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman(58));
            Console.ReadKey();
        }
    }
}
