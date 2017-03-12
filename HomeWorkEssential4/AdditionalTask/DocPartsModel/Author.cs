using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Author : BaseDocPart
    {
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" Author книги - {0} ", Name);
        }
    }
}
