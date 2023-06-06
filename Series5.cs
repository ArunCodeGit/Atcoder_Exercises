using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class Series5
    {
        #region Pair
        public static void Pair()
        {
            int K = Convert.ToInt32(Console.ReadLine());
            int EvenCount = 0;
            int OddCount = 0;
            for(int i=1; i<=K;i++)
            {
                if (i % 2 == 0)
                {
                    EvenCount++;
                }
                else
                {
                    OddCount++;
                }
            }
            Console.WriteLine(EvenCount*OddCount);
        }
        #endregion

        #region Round One
        public static void Round_One()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            if((A == 1 && B==2) || (A==2 && B==1))
            {
                Console.WriteLine("3");
            }
            else if((A==3 && B==1) || (A==1 && B==3))
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
        #endregion

        #region Train
        public static int Train()
        {
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = Input[0];
            int i = Input[1];
            return (N - i) + 1;
        }
        #endregion

        #region Albhapet
        public static char Albhapet()
        {
            char c = Convert.ToChar(Console.ReadLine());
            return (char)(c + 1);
        }
        #endregion

        #region Count Balls
        public static void CountBalls()
        {
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = Input[0], A = Input[1], B = Input[2];

        }
        #endregion
    }
}
