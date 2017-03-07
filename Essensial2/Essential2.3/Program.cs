using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Oleg", "Panyukov");
            employee.ShowEmployee("директор", 10, 13);

            Employee employee2 = new Employee("Marina", "Fortuna");
            employee2.ShowEmployee("секретарь", 5, 13);

            Console.ReadKey();

        }
    }
}
