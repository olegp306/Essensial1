using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            RedColorPrinter redColorPrinter = new RedColorPrinter();
            YellowColorPrinter yellowColorPrinter = new YellowColorPrinter();

            printer.Print("Тестовая строка");
            redColorPrinter.Print("Тестовая строка");
            yellowColorPrinter.Print("Тестовая строка");

            RedColorPrinter test = printer as RedColorPrinter;
            if (test != null)
            {
                test.Print("Printer привел к RedPrinter");
            }
            else
            {
                Console.WriteLine("Не удалось привести var test=printer as RedColorPrinter;");
            }
            // as безопасное приведение тольок на null проверить
            Printer test2 = redColorPrinter as Printer;
            if (test2 != null)
            {
                test2.Print("Printer test2 = redColorPrinter as Printer; Таким образом test2 типа Printer вызывает метод переодпределенный в RedColorPrinter ");
            }
            else
            {
                Console.WriteLine("Не удалось привести var Printer test2 = redColorPrinter as Printer;");
            }

            //is
            Console.BackgroundColor = ConsoleColor.Black;
            Printer test3 = new Printer();
            if (test3 is YellowColorPrinter)
            {
                Console.WriteLine("Printer можно привести к YellowColorPrinter");
            }
            else {
                Console.WriteLine("Printer НЕЛЬЗЯ  привести к YellowColorPrinter");
            }

            if (yellowColorPrinter is Printer)
            {
                Console.WriteLine("yellowColorPrinter можно привести к YellowColorPrinter");
            }
            else
            {
                Console.WriteLine("yellowColorPrinter НЕЛЬЗЯ  привести к YellowColorPrinter");
            }


            if (redColorPrinter is YellowColorPrinter)
            {
                Console.WriteLine("Printer можно привести к YellowColorPrinter");
            }
            else
            {
                Console.WriteLine("RedColorPrinter НЕЛЬЗЯ  привести к YellowColorPrinter");
            }

            var test4=yellowColorPrinter as Printer;
            if (test4 != null)
            {
                var test5=test4 as RedColorPrinter;
                if (test5 != null)
                    test5.Print("привел yeloow к printer а затем к redcolorPrinter");
            }
            Console.ReadKey();
        }
    }
}
