using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._1
//    Задание 2 
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс, представляющий учебный класс ClassRoom.  
//Создайте класс ученик Pupil.  В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().  
//Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.
//Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.
//Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.
//Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.

{
    public class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil Study()");
        }
        public virtual void Read()
        {
            Console.WriteLine("Pupil Read()");
        }
        public virtual void Write()
        {
            Console.WriteLine("Pupil Write()");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Pupil Relax()");
        }

    }
}
