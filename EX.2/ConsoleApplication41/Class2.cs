using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Time : Date
    {
        public string pib = "Andorosov Volodymyr Adndriyovich";
        int timeofwork;
        int wday = 13;
        int wmonth = 11;
        int wyear = 1988;
        public void TIMEOFWORK()
        {
            Console.WriteLine("Вступил на работу : " + wyear);
            timeofwork = year - wyear;
                Console.WriteLine("Кол-во лет на работе : " + timeofwork);
        }


    }
}
