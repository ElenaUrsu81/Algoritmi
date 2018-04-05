using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    public static class StringReverse
    {
        public static void ReverseString(string str)
        {
            char[] strReverse = str.ToCharArray();


            if (str.Length <= 1)
                Console.WriteLine(str);
            else
               for (int i = 0; i < strReverse.Length / 2; i++)
                    {
                        var temp = strReverse[i];
                        strReverse[i] = strReverse[strReverse.Length - 1 - i];
                        strReverse[strReverse.Length - 1 - i] = temp;

                    }
           
            string mystr = new string(strReverse);
            Console.WriteLine(mystr);

        }
    }
}
