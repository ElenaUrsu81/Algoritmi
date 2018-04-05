using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NFactorial
{
    class Program
    {

        static double RecursiveFactorial(int n)
        {
            if ((n == 0) || (n == 1))
                return 1;
            
            return Factorial(n - 1) * n;

        }

        static double Factorial(int n)
        {
            double first = 0;
            double second = 1;
            double fact = 0;

            if ((n == 0) || (n == 1))
                return 1;
            else
            { 
              for(int i=2; i<=n; i++)
              {
                  fact = i * second;
                  first = second;
                  second = fact;

              }
              return fact;
            
            }
        
        }
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("enter a number");
            bool flag = Int32.TryParse(Console.ReadLine(), out n);
            if (flag == false)
            {
                Console.WriteLine("you did'n entered a number!");
                Console.ReadLine();
            }
            else
            {
                //Console.WriteLine("Recursiv {0}! : {1}", n, RecursiveFactorial(n));
                Console.WriteLine("{0}! : {1}", n, Factorial(n));
                Console.ReadLine();
            }
               
            

        }
    }
}
