using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essensial2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конвертер валют");
            Converter converter = new Converter(0.035, 0.037, 2.16);

            converter.ShowGrivnaInAllCurrency(100);

            converter.ShowEuro(100);
            converter.ShowUsd(100);
            converter.ShowRub(100);

            Console.ReadKey();
        }
    }
}
