using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Date
    {
        public int day;
        public int month;
        public int year;
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void Proverka1()
        {

            if (month == day)
                Console.WriteLine("Номер месяца и дня совпадают!");
            else
                Console.WriteLine("Номер месяца и дня не совпадают!");
        }
    }
    class Liku : Date
    {
        public int likuyear;
        public int likumonth;
        public int likuday;
        public string firma;
        public string name;
        public int answeryear, answermonth, answerday, answer;
        public Liku(int day, int month, int year, int likuyear, int likumonth, int likuday, string firma, string name) : base(day, month, year)
        {
            this.likuday = likuday;
            this.likumonth = likumonth;
            this.likuyear = likuyear;
            this.name = name;
            this.firma = firma;
        }
        public void howdays()
        {
            if (year > likuyear)
            {
                answeryear = 360 * (year - likuyear);
                answermonth = 30 * (month - likumonth);
                answerday = day - likuday;
                answer = answeryear + answermonth + answerday;
                Console.WriteLine("Ваш ответ : " + answer + " дней");
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Date date = new Date(05, 12, 1995);
                date.Proverka1();
                Liku l = new Liku(02, 02, 2016, 2015, 03, 03, "КомпаниАндросов", "adaptol");
                l.howdays();
                Console.ReadLine();



            }
        }
    }
}

