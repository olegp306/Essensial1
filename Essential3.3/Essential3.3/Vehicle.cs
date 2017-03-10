using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3._3
{
    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:  
    //Создать класс Vehicle.
    //В теле класса создайте поля:  координаты и параметры средств передвижения (цена, скорость, год выпуска).  
    //Создайте 3 производных класса Plane, Саг и Ship.
    //Для класса Plane должна быть определена высота и количество пассажиров.
    //Для класса Ship — количество пассажиров и порт приписки.
    //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

    class Vehicle
    {
        double longtitude;
        public double Longtitude { get { return longtitude; } }

        double lantitude;
        public double Lantitude { get { return lantitude; } }

        long price;
        public double Price { get { return price; } }

        int speed;
        public double Speed { get { return speed; } }

        int releaseYear;
        public double ReleaseYear { get { return releaseYear; } }

        public Vehicle(double longtitude, double lantitude, long price, int speed, int releaseYear)
        {
            this.longtitude = longtitude;
            this.lantitude = lantitude;
            this.price = price;
            this.speed = speed;
            this.releaseYear = releaseYear;
        }

        public virtual void Show()
        {
            Console.WriteLine("Координаты средства широта-{0}  долгота- {1}",Longtitude,Lantitude);
            Console.WriteLine("Цена средства- {0}",Price);
            Console.WriteLine("Максимальная скорость- {0}",Speed);
            Console.WriteLine("Год выпуска - {0}", ReleaseYear);
        }
    }
}
