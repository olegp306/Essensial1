using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essensial2._2
{
    public class Converter
    {
        readonly double UsdRate;
        readonly double EuroRate;
        readonly double RubRate;

        //double GrivnaAmount;

        public double Rub;

        public Converter(double usdRate, double euroRate, double rusRate)
        {
            this.UsdRate = usdRate;
            this.EuroRate = euroRate;
            this.RubRate = rusRate;
        }

      

        public void ShowGrivnaInAllCurrency(double grivnaAmount)
        {
            Console.WriteLine("У вас {0}гривен  это {1} долларов, {2} евро, {3} рублей", grivnaAmount, grivnaAmount / UsdRate, grivnaAmount / EuroRate, grivnaAmount / RubRate);
        }

        public void ShowEuro(double grivnaAmount)
        {
            Console.WriteLine("У вас {0}гривен  это {1} евро ", grivnaAmount, EuroRate * grivnaAmount);
        }

        public void ShowUsd(double grivnaAmount)
        {
            Console.WriteLine("У вас {0} гривен  это {1} долларов ", grivnaAmount, UsdRate * grivnaAmount);
        }

        public void ShowRub(double grivnaAmount)
        {
            Console.WriteLine("У вас {0} гривен  это {1} рублей ", grivnaAmount, RubRate * grivnaAmount);
        }

    }
}
