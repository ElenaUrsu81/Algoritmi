using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Substring
{
    class Program
    {
        /*Scrieti un algoritm care sa verifice ca un string este substring al altui string */

        static int FindSubstring(char[] arr1, char[] arr2)
        {
            //bool isSubstring = false;
            int count = 0;
            for (int i = 0; i <= (arr2.Length - arr1.Length) ; i++)
            {
               bool found = true;


                for (int j = 0; (j <= arr1.Length - 1) && (found); j++)
                {

                    if (arr2[i+j] != arr1[j])
                        found = false;

                }

                if (found)
                    count++;
               
            }

            return count;

        }


          /*  int j = 0;
            int i = 0;
            bool[] flag = new bool[arr1.Length];
           
            for (int k = 0; k < arr1.Length - 1; k++)
                flag[k] = false;

                do
                {
                    if (arr1[i] == arr2[j])
                    {
                        i++;
                        j++;
                        flag[i] = true;
                    }
                    else
                    {
                        flag[i] = false;
                        j++;

                    }


                } while ((j < arr2.Length - 1) || (i < arr1.Length - 1));


                foreach (var fl in flag)
                {
                    if (fl == false)
                        return false;
                    else
                        return true;
                }*/

    

              
         
        
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string: ");
            string str2 = Console.ReadLine();

           

            char[] _str1 = str1.ToLower().ToCharArray();
            char[] _str2 = str2.ToLower().ToCharArray();

            if (_str1.Length <= _str2.Length)
                Console.WriteLine("{0}", FindSubstring(_str1, _str2));
            else
                Console.WriteLine("{0}", FindSubstring(_str2, _str1));
            */

         /*   int n;
            Console.WriteLine("Enter a number for Fibonacci series: ");
            bool flag = Int32.TryParse(Console.ReadLine(),out n);

            if (!flag)
            {
                Console.WriteLine("You didn't entered a number!");
                Console.ReadLine();
            }
            else
            {
                Fibonacci.FibonacciSeries(n);
                Fibonacci.FibonacciSeriesArr(n);
                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine(" {0} ", Fibonacci.FibonacciRecursive(i));

                }
            }
              */

          /*  Console.WriteLine("Enter a string array: ");
            string str = Console.ReadLine();
            string[] splitArr = new string[]{" ",","};
            string[] myArray = str.Split(splitArr, StringSplitOptions.RemoveEmptyEntries);

            ArrayReverse.ReverseArr(myArray);*/


           /* Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            StringReverse.ReverseString(str);*/


            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            StringModif.StrModify(str);
            //StringModif.StrModifyUppercase(str);




        }
    }
}
