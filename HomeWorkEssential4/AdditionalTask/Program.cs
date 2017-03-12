using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ продукта");
            string key = Console.ReadLine();
            if (key != null)
            {
                DocumentWorker document = null;
                switch (key)
                {
                    case "111":
                        document = new ExpertDocumentWorker();
                        break;
                    case "222":
                        document = new ProDocumentWorker();
                        break;
                    default:
                        Console.WriteLine("Ключ неверен");
                        document = new DocumentWorker();
                        break;
                }

                if (document != null)
                {
                    document.OpenDocument();
                    document.EditDocument();
                    document.SaveDocument();
                }
            }
            Console.ReadKey();
        }
    }
}
