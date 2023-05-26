using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class Series1
    {
        #region Wrong Subtraction
        public static void WrongSubtraction()
        {
            string[] InputArray = Console.ReadLine().Split();
            int Number = int.Parse(InputArray[0]);
            int K = int.Parse(InputArray[1]);

            while(Number>0 && K>0)
            {
                if(Number%10==0)
                {
                    Number /= 10;
                    K--;
                }
                else
                {
                    Number -= 1;
                    K--;
                }
            }
            Console.WriteLine(Number);
        }
        #endregion

        #region Even Odds
        public static void EvenOdds(string[] strArray)
        {
            int Number = int.Parse(strArray[0]);
            int K = int.Parse(strArray[1]);
            int Result = 0;
            int MidValue = ((Number +1) / 2);
            if (MidValue > K)
            {
                Result = ((2 * K) - 1);
            }
            else
            {
                Result = 2 * (K - MidValue);
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region Three Point Goal
        public static void ThreePointGoal(string[] Input)
        {
            int X = int.Parse(Input[0]);
            int Y = int.Parse(Input[1]);

            if(X>Y && Y+3>X)
            {
                Console.WriteLine("Yes");
            }
            else if(Y>X && X+3>Y)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        #endregion

        #region New Year's Number
        public static void NewYearsNumber(int Input)
        {
            int[] MyArray = new int[Input];
            for(int i=0; i<Input;i++)
            {
                MyArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int j=0; j<MyArray.Length;j++)
            {
                int value = Convert.ToInt32(MyArray[j]);
                while(value > 1999 )
                {
                    if(value%2021==0 || value%10==1)
                    {
                        value -= 2021;
                    }
                    else
                    {
                        value -= 2020;
                    }
                                      
                }
                if (value == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
        #endregion

        #region Next Round
        public static void NextRound(string[] Input, string Scores)
        {
            int N = int.Parse(Input[0]);
            int K = int.Parse(Input[1]);
            int Count = 0;
            //string[] S = Scores.Split();
            //int[] Score = new int[S.Length];
            //for(int k=0; k<Score.Length;k++)
            //{
            //    Score[k] = int.Parse(S[k]);
            //}
            int[] Score = Scores.Split().Select(int.Parse).ToArray();
            for(int i=0; i<N; i++)
            {
                if (Score[i] >= Score[K - 1])
                {
                    if (Score[i]==0)
                    {
                        continue;
                    }
                    Count++;
                }
            }
            Console.WriteLine(Count);
        }
        #endregion
    }
}
