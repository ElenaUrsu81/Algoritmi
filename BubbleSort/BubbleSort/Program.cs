using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the array of numbers:");
            var myArray = Console.ReadLine();
            bool flag;
            bool fl = true;
            int temp;

            string[] separators = new string[] { " ", ",", " ,", ", ", "  ", ",," };
            string[] processedmyArray = myArray.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);
            int[] myInt = new int[processedmyArray.Length];


            for (int i = 0; i < processedmyArray.Length; i++)
            {
                flag = Int32.TryParse(processedmyArray[i], out myInt[i]);
                if (flag)
                {
                    Console.WriteLine(myInt[i]);
                }
                else Console.WriteLine("this element of the array is not integer!");

            }

            for (int i = 0; (i < myInt.Length - 1) && (fl); i++)
            {
                fl = false;

                for (int j = 0; j < myInt.Length - 1; j++)
                {
                    if (myInt[j] > myInt[j + 1])
                    {

                        temp = myInt[j];
                        myInt[j] = myInt[j + 1];
                        myInt[j + 1] = temp;
                        fl = true;
                    }


                }

            }

            Console.WriteLine("Sorted array:");
            foreach (var elem in myInt)
            {
                Console.Write(" " + elem + " ");
            }

        }
    }
}
