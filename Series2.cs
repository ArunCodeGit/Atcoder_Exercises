using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Series
{
    internal class Series2
    {
        //https://codeforces.com/problemset/problem/131/A

        #region 1. cAPS LOCK
        public static void CapsLock(string Word)
        {
            char[] ch = Word.ToCharArray();
            bool AccResult = IsCapsLock_Accident(ch);
            if ((AccResult == true) && (ch[0] >= 65 && ch[0] <= 90))
            {
                for (int j = 0; j < ch.Length; j++)
                {
                    ch[j] = (char)(ch[j] + 32);
                }
            }
            else if (AccResult == false)
            {

            }
            else if (AccResult == true && (ch[0] >= 97 && ch[0] <= 122))
            {
                for (int i = 0; i < ch.Length; i++)
                {
                    if (i == 0)
                    {
                        ch[0] = (char)(ch[0] - 32);
                    }
                    else
                    {
                        ch[i] = (char)(ch[i] + 32);
                    }
                }
            }
            Console.WriteLine(ch);
        }
        private static bool IsCapsLock_Accident(char[] ch)
        {
            int i = 0;
            int Accidentcount = 0;
            while (i < ch.Length)
            {
                if ((i != 0) && (ch[i] >= 65 && ch[i] <= 90))
                {
                    Accidentcount++;
                }
                i++;
            }
            return (Accidentcount == (ch.Length - 1));
        }
        #endregion

        #region 2. Large Digits
        public static int Large_Digits(int[] Input)
        {
            int Input1 = ReturnSingleDig(Input[0]);
            int Input2 = ReturnSingleDig(Input[1]);
            return Input1>Input2 ? Input1 : Input2;
        }
        private static int ReturnSingleDig(int Number)
        {
            int sum = 0;
            while(Number>0)
            {
                sum += Number % 10;
                Number /= 10;
            }
            return sum;
        }
        #endregion

        #region 3. Fox and Snake
        public static void FoxAndSnake(int[] Input)
        {
            int Input1 = Input[0];
            int Input2 = Input[1];
            int Count = 0;
            for(int i=0; i<Input1;i++)
            {
                if(i%2==1)
                {
                    Count++;
                }
                for(int j=0; j<Input2;j++)
                {                    
                    if(i%2==0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        if(Count%2!=0)
                        {
                            if(j!=Input2-1)
                            {
                                Console.Write(".");
                            }
                            else
                            {
                                Console.Write("#");
                            }                            
                        }
                        
                        else
                        {
                            if(j==0)
                            {
                                Console.Write("#");
                            }
                            else
                            {
                                Console.Write(".");
                            }                            
                        }
                    }                    
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region 4. Orthogonality
        public static string Orthogonality()
        {
            int Number = Convert.ToInt32(Console.ReadLine());
            int[] Input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] Input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Sum = 0;
            for(int i=0; i<Number;i++)
            {
                int a = Input1[i];
                int b = Input2[i];
                Sum += a * b;
            }
            return Sum == 0 ? "Yes" : "No";
        }
        #endregion

        #region 5. Registration Systme
        public static void Registration_System()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] Str = new string[N];
            for(int i=0; i<N;i++)
            {
                Str[i] += Console.ReadLine();
            }
            Dictionary<string, int> MyList = new Dictionary<string, int>();
            for(int j=0; j<Str.Length;j++)
            {
                if (!MyList.ContainsKey(Str[j]))
                {
                    MyList.Add(Str[j], 1);
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine($"{Str[j]}{MyList[Str[j]]++}");
                }
            }
        }
        #endregion

    }
}
