using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1._3
{
    class Author
    {
        public string Name;

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" Author книги - {0} ", Name);
        }
    }
}
