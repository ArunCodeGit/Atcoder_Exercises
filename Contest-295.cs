using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class Contest_295
    {
        //Contests URL: https://atcoder.jp/contests/abc295/tasks

        #region A - Probably English
        public static void Probably_English()
        {
            int Length = int.Parse(Console.ReadLine());
            string[] Input = Console.ReadLine().Split();
            int count = 0;
            foreach (string word in Input)
            {
                if (word.Equals("and") || word.Equals("that") || word.Equals("not") || word.Equals("the") || word.Equals("you"))
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        #endregion

        #region C - Socks
        public static void Socks()
        {
            int N = int.Parse(Console.ReadLine());
            string[] StrArray = Console.ReadLine().Split(" ");
            Array.Sort(StrArray);
            int Ans = 0;
            int i = 0;
            while (i + 1 < N)
            {
                if (StrArray[i] == StrArray[i + 1])
                {
                    Ans++;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(Ans);
        }
        #endregion

        #region 
        public static string Problem4()
        {
            int a = int.Parse(Console.ReadLine());
            string Result = string.Empty;
            string[] input = Console.ReadLine().Split("|");
            if (input[1].Contains("*"))
            {
                Result = "In";
            }
            else
            {
                Result = "Out";
            }
            return Result;
        }
        #endregion

    }
}
