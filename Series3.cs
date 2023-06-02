using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class Series3
    {
        #region Blackjack
        public static string Blackjack()
        {
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int Sum = 0;
            for(int i=0; i<Input.Length;i++)
            {
                Sum += Input[i];
            }
            return Sum >= 22 ? "bust" : "win";
        }
        #endregion

        #region Poor
        public static void Poor()
        {
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (Input[0] == Input[1] && Input[1] == Input[2])
            {
                Console.WriteLine("No");
            }
            else if (Input[0] == Input[1] || Input[1] == Input[2] || Input[2] == Input[0])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        #endregion

        #region Station and Bus
        public static void StationBus()
        {
            string str = Console.ReadLine();        
            if ((str[0] == str[1] && str[0] == str[2]))
            {
                Console.Write("No");
            }
            else
            {
                Console.Write("Yes");
            }
        }
        #endregion

        #region Papers, Please
        public static void PapersPlease()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string Result = string.Empty;
            for(int i=0; i < Input.Length; i++)
            {
                if (Input[i]%2==0)
                {
                    if((Input[i] % 5 == 0) || (Input[i] % 3 == 0))
                    {
                        Result = "APPROVED";
                    }
                    else
                    {
                        Result = "DENIED";
                        break;
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(Result);
        }
        #endregion

        #region Cheap Travel
        public static void CheapTravel()
        {
            string[] Input = Console.ReadLine().Split();
            List<int> Result = new List<int>();
            int FullSingleRide = FullSingleRidePrice(int.Parse(Input[0]), int.Parse(Input[2]));
            int FullGroup = FullGroupNoRemainder(int.Parse(Input[0]), int.Parse(Input[1]), int.Parse(Input[3]));
            int MixedRide = MixedRidePrice(int.Parse(Input[0]), int.Parse(Input[1]), int.Parse(Input[2]), int.Parse(Input[3]));

            Result.Add(FullSingleRide);
            Result.Add(FullGroup);
            Result.Add(MixedRide);
            
            if(FullGroup<MixedRide)
            {
                Console.WriteLine(FullGroup);
            }
            else
            {
                Console.WriteLine(Result.AsEnumerable().Min());
            }          
        }
        private static int FullSingleRidePrice(int NoOfRounds, int PerRidePrice)
        {
            return NoOfRounds * PerRidePrice;
        }
        private static int FullGroupNoRemainder(int n, int m, int b)
        {
            int RideCount = 0;
            int Result = 0;
            while(n>RideCount)
            {
                Result += b;
                RideCount += m;
            }
            return Result;
        }
        private static int MixedRidePrice(int n, int m, int a, int b)
        {
            int Ridecount = 0;
            int Result = 0;
            while(n>Ridecount)
            {
                if(m<n-Ridecount || a>=b)
                {
                    Ridecount += m;
                    Result += b;
                }
                else
                {
                    Ridecount += 1;
                    Result += a;
                }
            }            
            return Result;
        }
        #endregion
    }
}
