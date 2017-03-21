using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDocument doc1 = new MyDocument();
            doc1.Title = "Книга 1";
            doc1.Body = "Body shmody";
            doc1.Footer = "Fotter shmooter";

            MyDocument doc2 = new MyDocument("Эта книга ни о чем"," Здравствуй дорогой читалель. Читай тело книги"," И напоследок. Конец");
            doc1.Show();
            doc2.Show();
     
            Console.ReadKey();
        }
    }
}
