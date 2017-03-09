using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3
{
    class RedColorPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red Color Printer value={0}", value);
        }
    }
}
