using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class Series2
    {
        public static void CapsLock(string Word)
        {
            Word = Word.ToLower();
            char[] ch = Word.ToCharArray();
            for(int i=0; i<ch.Length;i++)
            {
                if (Word[0]>=97 && Word[0]<=122)
                {
                    ch[0] = (char)(ch[0] - 32);
                }
                Console.Write(ch[i]);
            }
        }
    }
}
