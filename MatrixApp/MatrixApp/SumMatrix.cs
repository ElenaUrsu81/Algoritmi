using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    static class SumMatrix
    {

        public static int SumElemMatrix(int[,] matrix)
        {
            int sum = 0;
            int r, c;

            for (c = 0; c < matrix.GetLength(1); c++)
            {
                sum = sum + matrix[0, c];
                sum = sum + matrix[matrix.GetLength(0) - 1, c];
            }


            for (r = 1; r < matrix.GetLength(0) - 1; r++)
            {
                sum = sum + matrix[r, matrix.GetLength(1) - 1];
                sum = sum + matrix[r, 0];
            }


            return sum;



        }
    }
}
