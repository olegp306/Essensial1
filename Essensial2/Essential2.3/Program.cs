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
            employee.WorkExperience = 10;
            employee.ShowEmployee();

            Console.WriteLine();

            Employee employee2 = new Employee("Marina", "Fortuna");
            employee2.Position = "секретарь";
            employee2.WorkExperience = 5;
            employee2.ShowEmployee();

            Console.ReadKey();

        }
    }
}
