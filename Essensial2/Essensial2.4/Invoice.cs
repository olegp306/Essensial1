using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essensial2._4
{
    public class Invoice
    {
        //        Задание 4 
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Требуется:  
        //Создать класс Invoice.
        //В теле класса создать три поля int account, string customer, string provider которые должны быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения.
        //В теле класса создать два закрытых поля string article, int quantity
        //Создать метод расчета стоимости заказа с НДС и без НДС.
        //Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС
        const double ndsAmount = 13;

        readonly int account;
        readonly string customer;
        readonly string provider;

        string article;
        int quantity;

        public string Article
        {
            get
            {
                return article;
            }
            set
            {
                article = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public void ShowOrder(double cost)
        {
            Console.WriteLine("Оформение заказа !!!");
            Console.WriteLine("Аккаунт- {0} ", account);
            Console.WriteLine("Покупатель- {0} ", customer);
            Console.WriteLine("Организация по доставке - {0} ", provider);

            Console.WriteLine("Вы заказали {0} в кол-ве {1} штук", Article, Quantity);

            Console.WriteLine("Сумма БЕЗ НДС составит {0}", CalculateOrder(false, cost));
            Console.WriteLine("Сумма с НДС составит {0}", CalculateOrder(true, cost));
        }

        double CalculateOrder(bool withNds, double cost)
        {
            if (withNds)
                return ndsAmount * (cost * quantity)/100 + (cost * quantity);
            else
                return (cost * quantity);
        }
    }

}
