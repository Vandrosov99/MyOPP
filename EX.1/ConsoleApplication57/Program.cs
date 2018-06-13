using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication57
{
    class Date
    {
        public int year, month, day;
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
        public void Kratnost()
        {
            if (year % 4 == 0)
                Console.WriteLine("Этот год высокосный");
            else
                Console.WriteLine("Этот год не высокосный ");
        }

    }
    class Friend : Date
    {
        string pib;
        int numberofphone;
        int byear, bmonth, bday, answer;

        public Friend(string pib, int numberofphone, int byear, int bmonth, int bday, int year, int month, int day) : base(year, month, day)
        {
            this.pib = pib;
            this.numberofphone = numberofphone;
            this.byear = byear;
            this.bmonth = bmonth;
            this.bday = bday;
        }
        public void HowDaystoBirthday()
        {
            byear = (byear - year) * 365;
            bmonth = (bmonth - month) * 30;
            bday = bday - day;
            answer = bday + byear + bmonth;
            Console.WriteLine("Дней до следуещего Дня Рождения : " + answer);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Friend f = new Friend("Androsov Vova Andriyovich", 23012, 2018, 02, 02, 2017, 02, 02);

            f.Kratnost();
            f.HowDaystoBirthday();
            Console.ReadLine();
        }
    }
}
