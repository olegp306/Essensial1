using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._1
{
    public class ClassRoom
    {
        Pupil[] pupils = new Pupil[3];

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.pupils[0] = pupil1;
            this.pupils[1] = pupil2;
            this.pupils[2] = GenerateRndPupil();
        }

        private Pupil GenerateRndPupil()
        {
            var rnd = new Random();
            int rndPupil = rnd.Next(0, 2);
            switch (rndPupil)
            {
                case 0:
                    return new BadPupil();
                case 1:
                    return new GoodPupil();
                case 2:
                    return new ExcelentPupil();

                default:return new BadPupil();
            }
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            this.pupils[0] = pupil1;
            this.pupils[1] = pupil2;
            this.pupils[2] = pupil3;
        }


        void Study()
        {
            foreach (var pupil in pupils)
            {
                pupil.Study();
            }
        }
        void Write()
        {
            foreach (var pupil in pupils)
            {
                pupil.Write();
            }
        }
        void Read()
        {
            foreach (var pupil in pupils)
            {
                pupil.Read();
            }
        }
        void Relax()
        {
            foreach (var pupil in pupils)
            {
                pupil.Relax();
            }
        }

        public void ShowClass()
        {
            Console.WriteLine();
            Console.WriteLine("Результаты учеников класса");
            Study();
            Read();
            Write();
            Relax();
        }

    }
}
