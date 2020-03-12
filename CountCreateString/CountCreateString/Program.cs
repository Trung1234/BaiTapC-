using System;
using System.Text;

namespace CountCreateString
{
    class Program
    {
        static void Main(string[] args)
        {
            //method: return int, intput: string a,b, kiem tra co bao nhieu string a co the tao duoc tu cac ki tu co trong string b
            Console.WriteLine(CountGenerateString("abc", "axyzbcefabcfsfsadgdbc"));
            Console.ReadLine();
        }
        static int CountGenerateString(string stringA, string stringB)
        {
            //a = "abc", b = axyzbcefabc
            int result = 0;
            StringBuilder container = new StringBuilder(); ;
            foreach (char b in stringB)
            {
                if (stringA.Contains(b))
                {
                    container.Append(b);
                }
                if (stringA.Equals(container.ToString()))
                {
                    result++;
                    container.Clear();
                }
            }
            return result;
        }
    }
}
