using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.AddTitle("How I стал developer");
            book.AddAutor("Oleg PAnyukov");
            book.AddContent("Oleg Panyukov. My deleloper expirience is very diferent...");

            
            Console.ReadKey();
        }
    }
}
