using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._1
{
    class BadPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil Study()");
        }
        public override void Read()
        {
            Console.WriteLine("BadPupil Read()");
        }
        public override void Write()
        {
            Console.WriteLine("BadPupil Write()");
        }
        public override void Relax()
        {
            Console.WriteLine("BadPupil Relax()");
        }
    }
}
