using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Content:BaseDocPart
    {
             
        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Content книги - {0} ", Name);
        }
    }
}
