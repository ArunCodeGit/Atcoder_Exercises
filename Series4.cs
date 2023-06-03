using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class Series4
    {

        #region Don't Late
        public static void DontLate()
        {
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int D = Input[0];
            int T = Input[1];
            int S = Input[2];

            if (D <= T * S)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        #endregion

        #region Not
        public static int Not()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x == 0 ? 1 : 0;
        }
        #endregion

        #region Plural Form
        public static void Plural_Form()
        {
            string Input = Console.ReadLine();
            string Lastcharacter = Input.Substring(Input.Length - 1).ToString();
            if(Lastcharacter != "s")
            {
                Console.WriteLine($"{Input}s");
            }
            else
            {
                Console.WriteLine($"{Input}es");
            }
        }
        #endregion

        #region Product Max
        public static void ProductMax()
        {
            long[] Input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long a = (long)(Input[0] * Input[2]);
            long b = (long)(Input[0] * Input[3]);
            long c = (long)(Input[1] * Input[2]);
            long d = (long)(Input[1] * Input[3]);
            long Largest = d;
            if(a > Largest)
            {
                Largest = a;
            }
            if(b>Largest)
            {
                Largest = b;
            }
            if(c>Largest)
            {
                Largest = c;
            }
            Console.WriteLine(Largest);
        }
        #endregion

        public static void Product_Max1()
        {
            var Digit = Console.ReadLine().Split(' ').Select(s => long.Parse(s)).ToArray();

            var x = Digit[3] > 0 ? Digit[1] : Digit[0];
            var y = x > 0 ? Digit[3] : Digit[2];

            if (x * y < Digit[0] * Digit[2])
            {
                Console.WriteLine(Digit[0] * Digit[2]);
            }
            else
            {
                Console.WriteLine(x * y);
            }
        }


        #region Smartphone Addiction
        public static void SmartphoneAddiction()
        {
            string[] nums = Console.ReadLine().Split(' ');
            long n = long.Parse(nums[0]), m = long.Parse(nums[1]), t = long.Parse(nums[2]);
            long battery = n;
            long time = 0;
            for (int i = 0; i < m; i++)
            {
                string[] tmp = Console.ReadLine().Split(' ');
                long arrive = long.Parse(tmp[0]);
                long leave = long.Parse(tmp[1]);
                battery -= (arrive - time);
                if (battery <= 0) { Console.WriteLine("No"); return; }
                battery += (leave - arrive);
                if (battery > n) { battery = n; }
                time = leave;
            }
            battery -= (t - time);
            if (battery <= 0) { Console.WriteLine("No"); return; }
            Console.WriteLine("Yes");
        }
        #endregion

        #region Duodecim Ferra
        public static long Combinations(long n, long k)
        {
            if (n < k)
                return 0;

            long result = 1;
            for (long i = 1; i <= k; i++)
            {
                result *= n - k + i;
                result /= i;
            }
            return result;
        }
        #endregion
    }
}
