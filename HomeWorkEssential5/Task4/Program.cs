using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine("Ассортимент магазина ");
            for (int i = 0; i < store.Lenght; i++)
            {
                Console.WriteLine("Товар №{0}: {1}",i+1,store[i]);
                Console.WriteLine(  ); 
            }

            Console.WriteLine("Введите название товара:");
            string findProduct=Console.ReadLine();
            Console.WriteLine(store[findProduct]);

            Console.ReadKey();
        }
    }
}
