using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essensial2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Oleg", "Почта России");
            invoice.Article = "Пистолет";
            invoice.Quantity = 9;

            invoice.ShowOrder(120);

            Invoice invoice2 = new Invoice(1, "Marina", "Gruzovozov");
            invoice2.Article = "Кукла";
            invoice2.Quantity = 3;

            invoice2.ShowOrder(98);

            Console.ReadKey();
        }
    }
}
