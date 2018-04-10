using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    static class SpiralMatrix
    {

        public static List<int> Spiral(int[,] matrix)
        {

            List<int> result = new List<int>();
            if (matrix.Length > 0)
            {
                int rowNo = matrix.GetLength(0);
                int colNo = matrix.GetLength(1);
                int top = 0;
                int left = 0;

                while ((left < colNo) && (top < rowNo))
                {
                    for (int i = left; i < colNo; i++)
                        result.Add(matrix[top, i]);
                    top++;

                    for (int i = top; i < rowNo; i++)
                        result.Add(matrix[i, colNo - 1]);
                    colNo--;

                    if (left < colNo)
                    {
                        for (int i = colNo - 1; i >= left; i--)
                            result.Add(matrix[rowNo - 1, i]);
                        rowNo--;

                    }

                    if (top < rowNo)
                    {
                        for (int i = rowNo - 1; i >= top; i--)
                            result.Add(matrix[i, left]);
                        left++;

                    }


                }
            }



            return result;

        }
    }
	
}
