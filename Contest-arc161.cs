using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class Contest_arc161
    {

        #region MakeM
        public static void MakeM()
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            string[] str = Console.ReadLine().Split();
            for (var i = 0; i < N; i++)
            {
                A[i] = int.Parse(str[i]);
            }
            Array.Sort(A, (x, y) => y - x);
            string ans = "Yes";
            for (var i = 0; i < N / 2; i++)
            {
                int a1 = A[N / 2 + i];
                int a2 = A[N / 2 + 1 + i];
                if (a1 >= A[i])
                {
                    ans = "No";
                }
            }
            Console.WriteLine(ans);
        }
        #endregion

        #region Exactly Three Bits
        public static void Three_Bits()
        {
            int T = int.Parse(Console.ReadLine());
            for (var a = 0; a < T; a++)
            {
                long N = long.Parse(Console.ReadLine());
                long K = (long)Math.Pow(2, 61);
                long ans = 0;
                int t = 0;
                for (var i = 61; i >= 0; i--)
                {
                    if (t == 0 && ans + K + 3 <= N)
                    {
                        t++;
                        ans += K;
                    }
                    else if (t == 1 && ans + K + 1 <= N)
                    {
                        t++;
                        ans += K;
                    }
                    else if (t == 2 && ans + K <= N)
                    {
                        t++;
                        ans += K;
                    }
                    K /= 2;
                }
                if (t <= 2)
                {
                    ans = -1;
                }
                Console.WriteLine(ans);
            }
        }
        #endregion

    }
}