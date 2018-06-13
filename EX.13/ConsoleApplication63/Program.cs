using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Book
    {
        public int yearofpublic, monthofpublic, dayofpublic, yearnow, monthnow, daynow, yearafter, monthafter, dayafter;
       public  string nameofbook, nameofavtor;
        public Book(int yearofpublic,int  monthofpublic, int dayofpublic,int yearnow, int monthnow, int daynow,string nameofavtor,string nameofbook)
        {
            this.yearofpublic = yearofpublic;
            this.monthofpublic = monthofpublic;
            this.dayofpublic = dayofpublic;
            this.yearnow = yearnow;
            this.monthnow = monthnow;
            this.daynow = daynow;
            this.nameofavtor = nameofavtor;
            this.nameofbook = nameofbook;
            daysago();
        }
        public void daysago()
        {
            yearafter = yearnow - yearofpublic;
            if (monthnow > monthofpublic)
                monthafter = (monthnow - monthofpublic) * 360;
            else if (monthofpublic > monthnow)
                monthafter = (monthofpublic - monthnow) * 30;
            else if (daynow > dayofpublic)
                dayafter = daynow - dayofpublic;
            else
                dayafter = dayofpublic - daynow;
            Console.WriteLine("Дней с момента публикации : " + yearafter+monthafter+dayafter);
            
            
        }
    }
    class Book2 : Book
    {
        double sale, price, salewithprice, pricewithsale;
        public Book2(int yearofpublic, int monthofpublic, int dayofpublic, int yearnow, int monthnow, int daynow, string nameofavtor, string nameofbook, double price, double sale) : base(yearofpublic, monthofpublic, dayofpublic, yearnow, monthnow, daynow, nameofavtor, nameofbook)
        {
            this.price = price;
            this.sale = sale;
            FindPrice();
        }
        public  void FindPrice()
        {
            if (yearnow - yearofpublic > 5)
                
                  salewithprice = (price / 100) * sale;
                    pricewithsale = price - salewithprice;
            Console.WriteLine("Price with sale :" + pricewithsale);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book2 b = new Book2(2009, 02, 02, 2016, 02, 02,"vova", "asd", 100, 20);
        }
    }
}
