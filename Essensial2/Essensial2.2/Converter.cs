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
        readonly double RusRate;
        readonly double GrivnaRate;

        public double Rub;

        public Converter(double usdRate, double euroRate, double grivnaRate)
        {
            this.UsdRate = usdRate;
            this.EuroRate = euroRate;
            this.GrivnaRate = grivnaRate;
        }

      

        void ShowCurrencyInRuble()
        {
            Console.WriteLine("У вас {0}рублей  это {1}долларов,{2}евро, {3}гривен", Rub, Rub/UsdRate, Rub / EuroRate, Rub / GrivnaRate);
        }

        void ShowRubleInCurrency()
        {
            Console.WriteLine("У вас {0}рублей  это {1}долларов,{2}евро, {3}гривен", Rub, Rub / UsdRate, Rub / EuroRate, Rub / GrivnaRate);
        }

    }
}
