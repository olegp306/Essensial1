using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._1
{
   public  class ExcelentPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil Study()");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentPupil Read()");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentPupil Write()");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil Relax()");
        }
    }
}
