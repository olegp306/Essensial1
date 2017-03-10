using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._3
{
    //Для класса Ship — количество пассажиров и порт приписки.
    class Ship : Vehicle
    {
        int passengerAmount;
        public int PassengerAmount { get { return passengerAmount; } }
        string port;
        public string Port { get { return port; } }

        public Ship(double longtitude, double lantitude, long price, int speed, int releaseYear, string port, int passengerAmount)
            : base(longtitude, lantitude, price, speed, releaseYear)
        {
            this.port = port;
            this.passengerAmount = passengerAmount;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Вместимость пассажиров-{0} человек", PassengerAmount);
            Console.WriteLine("Корабль базируется в порту-{0} ", Port);
        }
    }
}
