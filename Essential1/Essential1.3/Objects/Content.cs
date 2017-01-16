using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1._3
{
    class Content
    {

        public string Name;

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Content книги - {0} ", Name);
        }
    }
}
