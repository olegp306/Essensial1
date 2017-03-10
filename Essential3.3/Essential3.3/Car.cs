using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._3
{
    class Car : Vehicle
    {
        public Car(double longtitude, double lantitude, long price, int speed, int releaseYear)
            : base(longtitude, lantitude, price, speed, releaseYear)
        {
        }
    }
}
