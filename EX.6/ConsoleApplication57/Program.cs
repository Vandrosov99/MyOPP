using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    class Time
    {
        int hours, minutes, seconds;
        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            HowTime();
        }

        void HowTime()
        {
            Console.WriteLine("Сейчас время :" + hours + "/" + minutes + "/" + seconds);
            hours = hours * 60;
            int answer = 1440 - (hours + minutes);
            Console.WriteLine("Вот столько еще минут к 24/00/00   ----- == " + answer);
        }
    }

    enum Predm
    {
        Matematika = 39,
        Engmova = 115,
        Programirovanie = 215,
        Fizkulture = 432
    }
    class Rozklad : Time
    {
        public Rozklad(int hours, int minutes, int seconds)
             : base(hours, minutes, seconds)
        {
            ChooseSub(hours, minutes);
        }

        void ChooseSub(int hours, int minutes)
        {
            if (hours == 9 && minutes == 30)
            {
                Console.WriteLine("Предмет : {0}, Номер аудиотори : {1}", Predm.Fizkulture, (int)Predm.Fizkulture);
            }

            else if (hours == 11 && minutes == 00)
            {
                Console.WriteLine("Предмет : {0}, Номер аудиотори : {1}", Predm.Matematika, (int)Predm.Matematika);
            }

            else if (hours == 12 && minutes == 40)
            {
                Console.WriteLine("Предмет : {0}, Номер аудиотори : {1}", Predm.Programirovanie, (int)Predm.Programirovanie);
            }

            else if (hours == 14 && minutes == 10)
            {
                Console.WriteLine("Предмет : {0}, Номер аудиотори : {1}", Predm.Engmova, (int)Predm.Engmova);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rozklad r = new Rozklad(09, 30, 00);
        }
    }
}

