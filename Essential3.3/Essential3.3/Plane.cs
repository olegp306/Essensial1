using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._3
{
    //Для класса Plane должна быть определена высота и количество пассажиров.
    class Plane : Vehicle
    {
        double altitude;
        public double Altitude { get { return altitude; } }
        
        int passengerAmount;
        public int PassengerAmount { get { return passengerAmount; } }

        public Plane(double longtitude, double lantitude, long price, int speed, int releaseYear, double altitude,int passengerAmount)
            : base(longtitude, lantitude, price, speed, releaseYear)
        {
            this.altitude = altitude;
            this.passengerAmount = passengerAmount;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Высота-{0} метров",Altitude);
            Console.WriteLine("Вместимость пассажиров-{0} человек", PassengerAmount);
        }
    }
}
