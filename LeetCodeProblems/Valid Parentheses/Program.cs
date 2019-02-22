using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses
{
    class Program
    {
        public static bool IsValid(string s)
        {
            var dic = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            var openBrackets = new List<char>();
            foreach(var ch in s)
            {
                if (!dic.ContainsKey(ch))
                {
                    if (openBrackets.Count == 0 || dic[openBrackets.Last()] != ch)
                        return false;
                    else openBrackets.RemoveAt(openBrackets.Count - 1);
                }
                else openBrackets.Add(ch);
            }

            return openBrackets.Count == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("[([]])"));
            Console.ReadKey();
        }
    }
}
