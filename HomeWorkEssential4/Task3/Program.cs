﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    //    Задание 3 
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:  
    //Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
    //Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
    //Написать программу, которая выполняет проигрывание и запись.

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            (player as IRecodable).Record();
            (player as IRecodable).Pause();
            (player as IRecodable).Stop();

            (player as IPlayable).Play();
            (player as IPlayable).Pause();
            (player as IPlayable).Stop();

            Console.ReadKey();
        }
    }
}
