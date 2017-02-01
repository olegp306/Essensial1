using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential1._4
{
    class Figure
    {
        Point[] points;
        string type;


        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[3];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            type = "Treangular";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {

            points = new Point[4];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            type = "Square";
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)

        {
            points = new Point[5];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            points[3] = point4;
            points[4] = point5;
            type = "FithAngular";
        }

        double LengthSide(Point A, Point B)
        {
            double test = Math.Sqrt(Math.Pow(A.Latitude - B.Latitude, 2) + Math.Pow(A.Longtitude - B.Longtitude, 2));
            return test;
        }

        public void Show()
        {
            Console.WriteLine("Данная фигура называеться {0}. ЕЕ периметр составляет {1}", type, PerimeterCalculator());
        }


        double PerimeterCalculator()
        {
            double result = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                result = result + LengthSide(points[i], points[i + 1]);
            }

            result += LengthSide(points[points.Length - 1], points[0]);

            return result;
        }
    }
}
