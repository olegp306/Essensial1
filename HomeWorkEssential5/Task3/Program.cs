using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(15, 15);
            matrix.ShowMatrix();
            Console.WriteLine("Было еще что -то  с возможностью изменения числа строк и столбцов. Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков. ");
            Console.WriteLine("Не стал не знаю о чем");
            Console.ReadKey();
        }
    }
}
