using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1._3
{
    class Title
    {

        public string Name;

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Title книги - {0} ", Name);
        }
    }
}
