using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class Series9
    {

        #region Determinant
        public static void Determinant(int[] Input1, int[] Input2)
        {
            Console.WriteLine((Input1[0] * Input2[1]) - (Input1[1] * Input2[0]));
        }
        #endregion

        #region ABC Preparation
        public static void ABCPreparation(int[] Input)
        {
            int Least = int.MaxValue;
            for(int i=0; i<Input.Length;i++)
            {
                if (Least > Input[i])
                {
                    Least = Input[i];
                }
            }
            Console.WriteLine(Least);
        }
        #endregion

        #region Takoyaki
        public static void Takoyaki(int[] Input)
        {
            int N = Input[0];
            int X = Input[1];
            int T = Input[2];

            if(N%X==0)
            {
                N /= X;
                Console.WriteLine(N*T);
            }
            else
            {
                N /= X;
                Console.WriteLine((N+1)*T);
            }
            
        }
        #endregion

        #region ChoosingTeams
        public static void ChoosingTeams(int[] InputArray)
        {
            int N = InputArray[0];
            int Ktimes = InputArray[1];
            int[] Team = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Count = 0;
            for (int i = 0; i < Team.Length; i++)
            {
                if (Ktimes + Team[i] <= 5)
                {
                    Count++;
                }
            }
            Console.WriteLine(Count / 3);
        }
        #endregion

        #region Expression
        public static void Expression(int A, int B, int C)
        {
            int Constraint1 = A + B * C;
            int Constraint2 = A * (B + C);
            int Constraint3 = A * B * C;
            int Constraint4 = (A + B) * C;
            int Constraint5 = A + B + C;
            int Constraint6 = (A * B) + C;

            int[] Result = new int[] { Constraint1, Constraint2, Constraint3, Constraint4, Constraint5, Constraint6 };
            Console.WriteLine(Result.Max());
        }
        #endregion

    }
}
