using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        //        Требуется:  
        //Создайте класс AbstractHandler.
        //В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
        //Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
        //Написать программу, которая будет выполнять определение документа
        //и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа

        static void Main(string[] args)
        {
            AbstractHandler[] docs = new AbstractHandler[3];

            for (int i = 0; i < docs.Count(); i++)
            {
                docs[i] = GetRndTypeDoc();
                docs[i].Create();
                docs[i].Open();
                docs[i].Change();
                docs[i].Save();
                Console.WriteLine();
            }


            Console.ReadKey();

        }

        public static AbstractHandler GetRndTypeDoc()
        {

            int rndInt = new Random().Next(0, 2);

            switch (rndInt)
            {
                case (0):
                    return new DOCHandler();
                case (1):
                    return new TXTHandler();
                case (2):
                    return new XMLHandler();
                default:
                    return new DOCHandler();
            }
        }
    }
}
