using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Combinations_of_a_Phone_Number
{
    class Program
    {
        public static IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return new List<string>();

            int ind = 1;

            var dic = Enumerable.Range('a', 'z' - 'a' + 1).Select((i, index) =>
            {
                var ch = (char)i;
                if (index % 3 == 0 && ch < 's')
                    ind++;
                else if (ch == 't' || ch == 'w')
                    ind++;
                return new { ind, ch };
            }).GroupBy(gr => gr.ind, gr => gr.ch).Select(gr=>new { gr.Key, gr }).ToDictionary(k=>k.Key, k=>k.gr);

            var list = digits.Select(ch=>int.Parse(ch.ToString())).ToList();

            var result = new List<string>();
            dic[list[0]].ToList().ForEach(ch => {
                result.Add(ch.ToString()); });
            list.RemoveAt(0);

            while (list.Count != 0)
            {
                int index = list[0];
                int count = result.Count;
                foreach(var ch2 in dic[index])
                {
                    for (int i = 0; i < count; i++)
                        result.Add(result[i] + ch2);
                }
                result.RemoveRange(0, count);

                list.RemoveAt(0);
            }

            return result;
        }

        static void Main(string[] args)
        {
            LetterCombinations("23");
            Console.ReadLine();
        }
    }
}
