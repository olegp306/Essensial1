using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask2
{
    class Body : DocPart
    {
        public override string Content
        {
            get
            {
                if (content == null)
                    return "Тело документа отсутствует";
                else
                    return content;
            }

            set
            {
               content = value;
            }
        }

        public override void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Со \r\n {0}", content);
        }
    }
}
