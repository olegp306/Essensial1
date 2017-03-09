using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3
{
    class YellowColorPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow Color Printer value={0}", value);
        }
    }
}
