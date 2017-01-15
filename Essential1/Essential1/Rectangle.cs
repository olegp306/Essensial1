using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1
{
    class Rectangle
    {
        double side1;
        double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        double AreaCalculator()
        {
            return side2 * side2;
        }
        double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        //Создать два свойства double Area и double Perimeter с одним методом доступа get.
        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }
}
