using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Matrix algorithms!");
            Console.WriteLine("Enter the numbers of rows:");
            int rowNo;
            bool rowFlag = Int32.TryParse(Console.ReadLine(), out rowNo);

            Console.WriteLine("Enter the numbers of columns:");
            int colNo;
            bool colFlag = Int32.TryParse(Console.ReadLine(), out colNo);

            if ((!rowFlag) || (!colFlag))
            {
                Console.WriteLine("The no. of rows or column is not an integer!");
            }
            else
            {
                int[,] matrix = new int[rowNo, colNo];

                for (int i = 0; i < rowNo; i++)
                    for (int j = 0; j < colNo; j++)
                    {
                        Console.WriteLine("row{0} col{1}", i, j);
                        matrix[i, j] = int.Parse(Console.ReadLine());

                    }


                int row = 0;
                do {

                    for (int j = 0; j < colNo; j++)
                    {
                        Console.Write(String.Format("  {0}  ", matrix[row, j]));
                    }
                    Console.WriteLine();
                    row++;
                }while (row<rowNo);



                /////SUMA ELEMENTELOR CE FORMEAZA MARGINEA MATRICEI

                
                Console.WriteLine("Sum of the elements from the matrix's margin is: {0}", SumMatrix.SumElemMatrix(matrix));

                //// PRINT MATRICEA IN SPIRALA

                if (rowNo == colNo)
                {
                    List<int> spiral = SpiralMatrix.Spiral(matrix);

                    foreach (int elem in spiral)
                        Console.Write("" + elem + "");


                }
                else Console.WriteLine("The matrix should be square for spiral print!!! ");



			}
	

        }
    }
}
