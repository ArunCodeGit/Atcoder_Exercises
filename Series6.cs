using System;
using System.Collections;
using System.Collections.Generic;

namespace Atcoder_Exercises
{
    class Atcoder_Exercises
    {
        public static void Main(string[] args)
        {
            //coffee();   //Input: coffee
            //GoldenCoins();  //Input: 1024
            //CompareString();   // Input: 5 6
            //Console.WriteLine(Goal());  //Input: 3 10 7   => 6 8
            //Battle();    //Input: 46 4 40 5
        }

        #region Coffee
        public static void coffee()
        {
            string strArray = Console.ReadLine();
            char[] chars = strArray.ToCharArray();
            if (chars[2] == chars[3] && chars[4] == chars[5])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        #endregion

        #region Golden Coins
        public static void GoldenCoins()
        {
            var Rupess = Convert.ToInt32(Console.ReadLine());
            var Coins = 0;
            int Quoation1 = Rupess / 500;
            int Quoation2 = (Rupess % 500) / 5;
            Coins = (Quoation1 * 1000) + (Quoation2 * 5);
            Console.WriteLine(Coins);
        }
        #endregion

        #region Comparing Strings
        public static void CompareString()
        {
            string[] InputArray = Console.ReadLine().Split();
            int a = int.Parse(InputArray[0]);
            int b = int.Parse(InputArray[1]);
            string Result = string.Empty;
            if (a > b)
            {
                for (int i = 0; i < a; i++)
                {
                    Result += b;
                }
            }
            else
            {
                for (int j = 0; j < b; j++)
                {
                    Result += a;
                }
            }
            Console.WriteLine(Result);
        }

        #endregion

        #region Achieve the Goal
        public static int Goal()
        {
            string[] strArray = Console.ReadLine().Split();
            var NumberOfSub = strArray[0];
            var MaxMark = strArray[1];
            var AvgMark = strArray[2];
            int Total = 0;
            string[] Mark = Console.ReadLine().Split();
            for (int i = 0; i < int.Parse(NumberOfSub) - 1; i++)
            {
                Total += int.Parse(Mark[i]);
            }
            int AvgProduct = int.Parse(AvgMark) * int.Parse(NumberOfSub);

            int SubMark = AvgProduct - Total;

            if (Total > AvgProduct)
            {
                return 0;
            }
            else if ((AvgProduct - Total) <= int.Parse(MaxMark))
            {
                return SubMark;
            }
            else
            {
                return -1;
            }
        }
        #endregion

        #region Battle
        public static void Battle()
        {
            string[] InputArray = Console.ReadLine().Split();
            var P1_Health = int.Parse(InputArray[0]);
            var P1_Attack = int.Parse(InputArray[1]);
            var P2_Health = int.Parse(InputArray[2]);
            var P2_Attack = int.Parse(InputArray[3]);

            while (true)
            {
                P2_Health -= P1_Attack;
                if (P2_Health <= 0)
                {
                    Console.WriteLine("Yes");
                    return;
                }

                P1_Health -= P2_Attack;
                if (P1_Health <= 0)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
        }
        #endregion

        #region Cards for Friends
        public static void cardsforFriends()
        {
            int Input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Input; i++)
            {
                string[] strArray = Console.ReadLine().Split();

            }
        }
        #endregion
    }
}
