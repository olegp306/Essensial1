using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential2._3
{
    class Employee
    {
        string firstName;
        string surName;

        //public string salary;
        public string position;
        public int workExperience;
        public double loan;

        public Employee(string firstName, string surName)
        {
            this.firstName = firstName;
            this.surName = surName;
        }

        private double getSalary(string position, int workExperience)
        {
            double salary = 0;
            switch (position)
            {
                case "директор":
                    salary = 1000 * workExperience * 1.1 * workExperience;
                    break;
                case "секретарь":
                    salary = 200 * workExperience * 1.1 * workExperience;
                    break;
                case "рабочий":
                    salary = 100 * workExperience * 1.1 * workExperience;
                    break;
                default:
                    salary = 100;
                    break;
            }
            return salary;
        }

        private double getLoanAmount(double salary)
        {
            return getLoanAmount(13,  salary);
        }

        private double getLoanAmount(double loan,double salary)
        {
            double loanAmount = 0;
         
            return loanAmount;
        }

        public void ShowEmployee(string position, int workExperience, double loan)
        {
            double salary = getSalary(position, workExperience);

            Console.WriteLine("Имя:{0}", firstName);
            Console.WriteLine("Фамилия:{0}", surName);
            Console.WriteLine("Должность:{0}", position);
            Console.WriteLine("Стаж:{0}", workExperience);
            Console.WriteLine("Налог на ЗП:{0}", loan);
            Console.WriteLine("Зарплата:{0}", salary);

        }
    }
}
