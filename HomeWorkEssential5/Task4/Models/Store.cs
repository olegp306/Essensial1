using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Store
    {
        Article[] products;
        public Store()
        {
            products = new Article[5];
            products[0] = new Article("Книга","Амазон.рф",101);
            products[1] = new Article("Молоко", "Пятерочка", 62);
            products[2] = new Article("Ашанбайк", "Ашан", 7999);
            products[3] = new Article("Поэнг", "Икеа", 5665);
            products[4] = new Article("Фига", "Али", 17.19f);
        }

        public int Lenght { get { return products.Length; } }
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i].Name == index)
                        return products[i].ProductInfo;
                  
                }
                return string.Format("{0} - нет товара с таким названием !", index);
            }
        }
        public string this[int index]
        {
            get
            {
               if(products.Length<index)
                    return string.Format("{0} - нет товара с таким индексом!", index);

                return products[index].ProductInfo;
            }
        }

    }
}
