using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential2._3
{
    class Employee
    {
        readonly string firstName;
        readonly string surName;
        readonly double defaultLoan = 13;

        string position;
        int workExperience;
        double loan;

        public String FirstName { get { return firstName; } set { } }
        public String SurName { get { return surName; } set { } }
        public String Position
        {
            get
            {
                if (position != null)
                    return position;
                else
                    return "неизвестная должность";
            }
            set
            {
                if (value != null)
                    position = value;
            }
        }
        public int WorkExperience
        {
            get { return workExperience; }
            set
            {
                if (value >= 0)
                    workExperience = value;
            }
        }
        public double Loan
        {
            get
            {
                if (loan == 0)
                    return defaultLoan;
                else
                    return loan;
            }
            set { if (value >= 0) loan = value; }
        }

        public Employee(string firstName, string surName, double loan)
        {
            this.firstName = firstName;
            this.surName = surName;
            this.loan = loan;
        }

        public Employee(string firstName, string surName)
        {
            this.firstName = firstName;
            this.surName = surName;
        }

        private double getSalary()
        {
            double salary = 0;
            switch (Position)
            {
                case "директор":
                    salary = 1000 * WorkExperience * 1.1 * WorkExperience;
                    break;
                case "секретарь":
                    salary = 200 * WorkExperience * 1.1 * WorkExperience;
                    break;
                case "рабочий":
                    salary = 100 * WorkExperience * 1.1 * WorkExperience;
                    break;
                default:
                    salary = 100;
                    break;
            }
            return salary;
        }

        private double getLoanAmount()
        {
            return getSalary() * Loan/100;
        }

        public void ShowEmployee()
        {
            double salary = getSalary();

            Console.WriteLine("Имя:{0}", FirstName);
            Console.WriteLine("Фамилия:{0}", SurName);
            Console.WriteLine("Должность:{0}", Position);
            Console.WriteLine("Стаж:{0}", workExperience);
            Console.WriteLine("Налог на ЗП:{0}", getLoanAmount());
            Console.WriteLine("Зарплата:{0}", salary);

        }
    }
}
