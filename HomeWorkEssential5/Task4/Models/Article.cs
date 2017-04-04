using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Article
    {
        string name;
        string shopName;
        float price;

        public Article(string name, string shopName, float price)
        {
            this.name = name;
            this.shopName = shopName;
            this.price = price;
        }

        public string Name { get { return name; } }
        public string ProductInfo
        {
            get
            {
                return "Товар:" + name + Environment.NewLine + "Магазин: " + shopName + Environment.NewLine + "Цена: " + price.ToString();
            }
        }
    }
}
