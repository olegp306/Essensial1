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
            employee.Position = "директор";
            employee.ShowEmployee( 10, 13);

            Employee employee2 = new Employee("Marina", "Fortuna");
            employee2.Position = "секретарь";
            employee2.ShowEmployee( 5, 13);

            Console.ReadKey();

        }
    }
}
