using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {

        static bool IsPrime(int no)
        {
            
            if (no < 2) return false;
            if (no == 2) return true;
            for (int i = 2; i <= no/2 + 1; i++)   
            {
                if (no % i ==0 )
                    return false;
               
               
            }
         return true;

        }


        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int no;
            bool flag = Int32.TryParse(Console.ReadLine(), out no);
            List<int> listNo = new List<int>();
            bool isprime;
            int j;
            if (flag)
            {
                for (int i = 0; i < no; i++)
                {
                    listNo.Add(i+1);
                    Console.WriteLine(" " + listNo[i] + " is {0} " , IsPrime(listNo[i]));
                    isprime = IsPrime(listNo[i]);
                 
                }



                for (int i = 0; i < listNo.Count; i++)
                {
                    isprime = IsPrime(listNo[i]);

                    if ((isprime == true)&& ((i*i)< no))
                    {
                        for (j = i + 1; j < listNo.Count; j++)

                            if (listNo[j] % listNo[i] == 0)
                            {
                                listNo.Remove(listNo[j]);

                            }
                    }
                }

                Console.ReadLine();

                
                Console.WriteLine("Prime Numbers: ");

                listNo.RemoveAt(0);                 
                foreach (var item in listNo)
                    Console.Write(" " + item + " ");
                  
                   
                    Console.ReadLine();


            }
            else
                Console.WriteLine ("You didn't entered a number!");


           
        

        }
    }
}
