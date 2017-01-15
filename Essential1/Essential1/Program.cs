using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1
{
    class Program
    {
        static void Main(string[] args)
        {

            //    Используя Visual Studio, создайте проект по шаблону Console Application.
            //Требуется:  
            //Создать класс Book.Создать классы  Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().  
            //Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
            //Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
            double a;
            double b;

            Console.WriteLine("Введите ширину:");
            double.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Введите длину:");
            double.TryParse(Console.ReadLine(), out b);

            Rectangle rectangle = new Rectangle(a, b);

            Console.WriteLine("Периметр прямогуальника равен: {0}", rectangle.Perimeter);

            Console.WriteLine("Площадь прямогуальника равена: {0}", rectangle.Area);
            Console.ReadKey();
        }
    }
}
