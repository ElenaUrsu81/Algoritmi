using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    public static class StringModif
    {

      
        public static void StrModify(string str)
        {
            StringBuilder strBuild = new StringBuilder();
            int asciiCode;

            foreach(char val in str)
            {
                asciiCode = System.Convert.ToInt32(val);
                if ((asciiCode >= 97) && (asciiCode <= 122))
                    strBuild.Append(val);
            }

            if (str.Length != strBuild.Length)
                Console.WriteLine("The strings contains elements that are not char!");

            for (int i = 0; i <= strBuild.Length - 1; i++)
            {
                Console.Write(" " + strBuild[i] + " ");
                
            }

            char[] result = strBuild.ToString().ToCharArray();

            for (int j = 0; j <= result.Length - 1; j++)
            {
                result[j] = (char)(System.Convert.ToInt32(result[j]) + 1);

                switch (result[j])
                {
                    case 'a': result[j] = char.ToUpper(result[j]); break;
                    case 'e': result[j] = char.ToUpper(result[j]); break;
                    case 'i': result[j] = char.ToUpper(result[j]); break;
                    case 'o': result[j] = char.ToUpper(result[j]); break;
                    case 'u': result[j] = char.ToUpper(result[j]); break;

                }

            }


            for (int j = 0; j <=result.Length - 1; j++)
                Console.Write(" " + result[j] + " ");
                
            


        }


      /*  public static void StrModifyUppercase(string str)
        {
            char[] mystr = str.ToCharArray();
            char[] vocals = new char[] {'a','e','i','o','u'};

            for (int i = 0; i < mystr.Length; i++)
                for (int j = 0; j < vocals.Length; j++)
                    if (mystr[i] == vocals[j])
                        mystr[i] = char.ToUpper(mystr[i]);

            


            foreach (char c in mystr)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();


        }*/


    }
}
