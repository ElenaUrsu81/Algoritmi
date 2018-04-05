using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
   public static class ArrayReverse
    {

       public static void ReverseArr( string[] arr)
       {
           
           if (arr.Length <= 1)
               Console.WriteLine(arr[0]);
           else

               for (int i = 0; i < arr.Length/2; i++)
               {
                   var temp = arr[i];
                   arr[i] = arr[arr.Length-1-i];
                   arr[arr.Length-1-i] = temp;
                             
               }

           foreach (var x in arr)
               Console.Write(" "+ x +" ");

       }





    }
}
