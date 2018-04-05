using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    public static  class Fibonacci
    {
        public static void FibonacciSeries(int n)
        {
            int first = 0;
            int second = 1;
            int current = 0;
            List<int> myFiboList = new List<int>();


            if (n == 0)  myFiboList.Add(0);
            if (n == 1)  myFiboList.Add(0);
            if (n >= 2)
            {
                myFiboList.Add(0);
                myFiboList.Add(1);
                for (int i = 2; i < n; i++)
                {
                    current = first + second;
                    first = second;
                    second = current;
                    myFiboList.Add(current);

                }

            }

            foreach (var x in myFiboList)
                Console.WriteLine(x);
                   
                          
        
        }

        public static void FibonacciSeriesArr(int n)
        {
           // int first = 0;
           // int second = 1;
            //int current = 0;
            int[] myFiboSeries = new int[n];

                     if ((n == 0) ||(n==1)) myFiboSeries[0] = 0;
            
            if (n >= 2)
            {
                myFiboSeries[0] = 0;
                myFiboSeries[1] = 1; 
                for (int i = 2; i < n ; i++)
                {
                   // current = first + second;
                   // first = second;
                    //second = current;
                    myFiboSeries[i] = myFiboSeries[i-1]+myFiboSeries[i-2];

                }

            }

            foreach (var x in myFiboSeries)
                Console.WriteLine(x);



        }
        public static int FibonacciRecursive(int n)
        {
            
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibonacciRecursive(n-1) + FibonacciRecursive(n-2);


        }

    }
}
