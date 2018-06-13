using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication57
{
    class Boock
    {
        public string name;
        public int price, NumberofPages;
        public Boock(int price, int NumberofPages, string name)
        {
            this.price = price;
            this.NumberofPages = NumberofPages;
            this.name = name;
            FindPrice();
        }
        public void FindPrice()
        {
            Console.WriteLine("Название книги : " + name);
            if (name == "Програмування")
                price = price * 2;
            Console.WriteLine("Цена на книгу = " + price);
        }
    }
    class Magazine : Boock
    {
        int sale;
        public Magazine(int price, int NumberofPages, string name, int sale) : base(price, NumberofPages, name)
        {
            this.sale = sale;
            PriceSale();
        }
        public void PriceSale()
        {
            double pricewithoutsale = (price / 100) * sale;
            Console.WriteLine("Скидка равна : " + pricewithoutsale);
            double pricewithsale = price - pricewithoutsale;
            Console.WriteLine("Цена на книгу со скидкой  : " + pricewithsale);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Magazine m = new Magazine(50, 12, "Програмування", 20);
        }
    }
}
