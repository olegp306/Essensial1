using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask2
{
    class Footer : DocPart
    {
        public override string Content
        {
            get
            {
                if (content == null)
                    return "футтер документа отсутствует";
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
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("И в конце \r\n {0}", content);
        }
    }
}
