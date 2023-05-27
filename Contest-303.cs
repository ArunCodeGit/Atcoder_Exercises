using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class Contest_303
    {
        //https://atcoder.jp/contests/abc303/tasks
        #region Similar_String
        public static void Similar_String(int value)
        {
            string S = Console.ReadLine();
            string T = Console.ReadLine();
            string Result = "Yes";
            int count = 0;
            for (int i = 0; i < value; i++)
            {
                if ((S[i].Equals(T[i]))) { }
                else if ((S[i].Equals('0') && T[i].Equals('o')) || (S[i].Equals('o') && T[i].Equals('0'))) { }
                else if ((S[i].Equals('1') && T[i].Equals('l')) || (S[i].Equals('l') && T[i].Equals('1'))) { }
                else
                {
                    Result = "No";
                    break;
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region Discord
        public static void Discord()
        {
            int[] inputs = Console.ReadLine().Trim().Split(' ').Select(x => int.Parse(x)).ToArray();
            int amount = inputs[0];
            int times = inputs[1];
            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < times; i++)
            {
                int[] lines = Console.ReadLine().Trim().Split(' ').Select(y => int.Parse(y)).ToArray();
                for (int j = 0; j < amount - 1; j++)
                {
                    set.Add(lines[j].ToString("D2") + lines[j + 1].ToString("D2"));
                    set.Add(lines[j + 1].ToString("D2") + lines[j].ToString("D2"));
                }
            }

            Console.WriteLine((amount * (amount - 1) / 2) - (set.Count / 2));

            //return 0;
        }
        #endregion

        #region Dash
        public static void Dash()
        {
            string[] NMHK = Console.ReadLine().Split(" ");
            int n = int.Parse(NMHK[0]);
            int m = int.Parse(NMHK[1]);
            int h = int.Parse(NMHK[2]);
            int k = int.Parse(NMHK[3]);

            char[] s = Console.ReadLine().ToCharArray();

            HashSet<string> item = new HashSet<string>();
            for (int i = 0; i < m; i++)
            {
                string xy = Console.ReadLine();
                item.Add(xy);
            }

            int x = 0;
            int y = 0;
            int power = h;
            string answer = "Yes";
            for (int i = 0; i < n; i++)
            {
                power--;

                if (power < 0)
                {
                    answer = "No";
                    break;
                }

                if (s[i] == 'R')
                    x++;
                else if (s[i] == 'L')
                    x--;
                else if (s[i] == 'U')
                    y++;
                else if (s[i] == 'D')
                    y--;

                if (power < k)
                {
                    string key = x.ToString() + " " + y.ToString();

                    if (item.Contains(key))
                    {
                        power = k;
                        item.Remove(key);
                    }
                }
            }

            Console.WriteLine(answer);
        }
        #endregion

    }
}
