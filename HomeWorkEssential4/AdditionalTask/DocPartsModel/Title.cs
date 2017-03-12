using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Title : BaseDocPart
    {
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Title книги - {0} ", Name);
        }
    }
}
