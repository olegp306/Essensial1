using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0, 0, 200000, 220, 2010);
            Plane plane = new Plane(0, 0, 15000000, 600, 2011, 0, 110);
            Ship Ship = new Ship(1, 1, 100000000, 50, 2017, "Мурманск", 3000);


            car.Show();
            Console.WriteLine();
            plane.Show();
            Console.WriteLine();
            Ship.Show();

            Console.ReadKey();
        }
    }
}
