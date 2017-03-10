using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            BadPupil badPaupil = new BadPupil();
            GoodPupil goodPupil = new GoodPupil();

            ExcelentPupil excelentPupil = new ExcelentPupil();

            ClassRoom class1 = new ClassRoom(badPaupil, goodPupil);
            ClassRoom class2 = new ClassRoom(badPaupil, goodPupil, excelentPupil);

            class1.ShowClass();
            class2.ShowClass();


            Console.ReadKey();

        }
    }
}
