using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Parentheses
{
    class Program
    {
        //Logic is not right
        //With IEnumarable<string>
        //public static IEnumerable<string> GenerateParenthesis(int n)
        //{
        //    if (n == 1)
        //    {
        //        yield return "()";
        //        yield break;
        //    }

        //    foreach(var str in GenerateParenthesis(n-1))
        //    {
        //        yield return string.Format("({0})", str);
        //        var str1 = string.Format("(){0}", str);
        //        var str2 = string.Format("{0}()", str);
        //        yield return str1;
        //        if (str1 != str2)
        //            yield return str2;
        //    }
        //}

        //Logic is not right
        //public static IList<string> GenerateParenthesis(int n)
        //{
        //    IList<string> list;
        //    if (n == 1)
        //    {
        //        list = new List<string> { "()" };
        //        return list;
        //    }

        //    list = new List<string>();
        //    var set = new HashSet<string>();
        //    foreach (var str in GenerateParenthesis(n - 1))
        //    {
        //        set.Add(string.Format("({0})", str));
        //        set.Add(string.Format("(){0}", str));
        //        set.Add(string.Format("{0}()", str));
        //    }



        //    list = set.ToList();
        //    return list;
        //}

        public static IList<string> GenerateParenthesis(int n)
        {
            IList<string> list = GenerateParenthesisRek(n).ToList();
            return list;
        }

        public static IEnumerable<string> GenerateParenthesisRek(int n)
        {
            if(n==0)
            {
                yield return "";
                yield break;
            }

            for (int c = 0; c < n; c++)
                foreach (var left in GenerateParenthesisRek(c))
                    foreach (var right in GenerateParenthesisRek(n - 1 - c))
                        yield return string.Format("({0}){1}", left, right);
        }

        static void Main(string[] args)
        {
            int index = 1;
            while (true)
            {
                Console.Write( string.Format("{0}) n = ", index));
                int n = int.Parse(Console.ReadLine());
                foreach (var str in GenerateParenthesis(n))
                    Console.WriteLine(str);
                index++;
            }
        }
    }
}
