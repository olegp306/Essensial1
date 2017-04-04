using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class VariousArray
    {
        int[] arr;

        public VariousArray(int sizeArray)
        {
            arr = new int[sizeArray];
            Random rnd = new Random();

            for (int i = 0; i < sizeArray ; i++)
            {
                arr[i] = rnd.Next(0, 50);
            }
        }

        public int FindMax()
        {
            int max = arr[0];
            foreach (var item in arr)
            {
                max = Math.Max(item, max);
            }
            return max;
        }

        public int FindMin()
        {
            int min = arr[0];
            foreach (var item in arr)
            {
                min = Math.Min(item, min);
            }
            return min;
        }

        public double ArithmeticMean()
        {
            return GetSumAll() / arr.Length;
        }

        public int GetSumAll()
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
        public void ShowAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
