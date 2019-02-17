using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_to_Integer__atoi_
{
    class Program
    {
        public static int MyAtoi(string str)
        {
            var str2 = str.TrimStart();

            if (string.IsNullOrEmpty(str2))
                return 0;
            if (str2[0] != '-' && str2[0] != '+' && !char.IsDigit(str2[0]))
                return 0;

            string str3 = new string(str2.TakeWhile((ch, index) => (index == 0 && ch == '-') || (index == 0 && ch == '+') || char.IsDigit(ch)).ToArray());

            if (string.IsNullOrEmpty(str3))
                return 0;

            int result;
            if (int.TryParse(str3, out result))
                return result;
            else
            {
                if (str3[0] == '-' && str3.Length > 1 && char.IsDigit(str3[1]))
                    return int.MinValue;
                if (char.IsDigit(str3[0]))
                    return int.MaxValue;
                if (str3[0] == '+' && str3.Length > 1 && char.IsDigit(str3[1]))
                    return int.MaxValue;
            }

            return 0;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                Console.WriteLine(MyAtoi(str));
            }
            Console.ReadKey();
        }
    }
}
