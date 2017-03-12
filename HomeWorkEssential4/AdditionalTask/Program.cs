using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется: Изменить 12 пример первого урока(работа с документом) и создать 
    //общий абстрактный класс для всех частей документа.

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.AddTitle("How I стал developer");
            book.AddAutor("Oleg PAnyukov");
            book.AddContent("Oleg Panyukov. My deleloper expirience is very diferent...");


            Console.ReadKey();
        }
    }
}
