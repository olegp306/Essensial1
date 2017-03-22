using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("DOCHandler Change()");
        }

        public override void Create()
        {
            Console.WriteLine("DOCHandler Create()");
        }

        public override void Open()
        {
            Console.WriteLine("DOCHandler Open()");
        }

        public override void Save()
        {
            Console.WriteLine("DOCHandler Save()");
        }
    }
}
