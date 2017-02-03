using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essensial2
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User("Oleg306", "oleg", "panyukov", 35);
            //user.DateOfCompletion = DateTime.Now.AddDays(2);
            user.Show();
            Console.ReadKey();
        }
    }
}
