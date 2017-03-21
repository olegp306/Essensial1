using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask2
{
    class Title : DocPart
    {
        public override string Content
        {
            get
            {
                if (content == null)
                    return "Заголовок документа отсутствует";
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
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Заголовок \r\n {0}", content);
        }
    }
}
