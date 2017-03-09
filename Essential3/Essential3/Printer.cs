using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3
{
    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:  
    //Создайте класс Printer.
    //В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
    //Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове соответствующего метода их экземпляра,
    //строки,переданные в качестве аргументов методов, выводились разными цветами.
    //Обязательно используйте приведение типов.  

    class Printer
    {
        public virtual void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Value ={0}", value);
        }
    }
}
