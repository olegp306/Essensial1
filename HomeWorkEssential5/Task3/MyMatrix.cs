using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    // Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера
    // с возможностью изменения числа строк и столбцов.
    // Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков. 

    class MyMatrix
    {
        int[,] matrix;

        public MyMatrix(int x, int y)
        {
            matrix = new int[x, y];
            fillMatrix();
        }

        void fillMatrix()
        {
            Random rnd = new Random();
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    matrix[x, y] = rnd.Next(10, 50);
                }
            }
        }

       public void ShowMatrix()
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    Console.Write(" {0}", matrix[x, y]);
                }
                Console.WriteLine();
            }
        }


    }
}
