using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        /*Используя Visual Studio, создайте проект по шаблону Console Application.  
        Требуется:  
        Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.  
        Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения. 
*/
        static void Main(string[] args)
        {

            VariousArray myArr = new VariousArray(15);

            myArr.ShowAll();
            Console.WriteLine("Макс:{0}", myArr.FindMax());
            Console.WriteLine("Мин:{0}", myArr.FindMin());
            Console.WriteLine("Среднее ариф:{0}", myArr.ArithmeticMean());
            Console.WriteLine("Общая сумма:{0}", myArr.GetSumAll());

            Console.ReadKey();

        }
        
    }
   
}
