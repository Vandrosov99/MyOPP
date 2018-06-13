using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Time
    {


        public int hours;
        public int minutes;
        internal int seconds;
        public int allseconds;
        public void dannye()
        {
            Console.WriteLine("hours");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("minutes");
            minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("seconds");
            seconds = Convert.ToInt32(Console.ReadLine());

            allseconds = 3600 * hours + 60 * minutes + seconds;
            Console.WriteLine("Кількість секунд в заданмоу часі : " + allseconds);
            Console.ReadLine();
            Console.WriteLine("Time: {0}:{1}:{2}", hours, minutes, seconds);
            Console.Read();
        }
    }
    class Train : Time
    {
        int numberoftrain;
        string napryamok;
        int timetraihours;
        int timetrainminutes;
        int timetrainseconds;
        int howmuchminutes, answer1, answer2;
        public Train(string napryamok, int numberoftrain, int timetrainhours, int timetrainminutes, int timetrainseconds)
        {
            this.napryamok = napryamok;
            this.numberoftrain = numberoftrain;
            this.timetraihours = timetraihours;
            this.timetrainminutes = timetrainminutes;
            this.timetrainseconds = timetrainseconds;
        }
        public void tableoftrains()
        {
            Console.WriteLine("Ваш Напрямок :" + napryamok);
            Console.WriteLine("Номер поезда : " + numberoftrain);
            Console.WriteLine("Время отправки : " + timetraihours + " часов " +  timetrainminutes + " минут " + timetrainseconds + " секунд ");

            if (hours > timetraihours)
                answer1 = (hours - timetraihours) * 60;
            else if (hours < timetraihours)
                answer1 = (timetraihours - hours) * 60;
            else
                if (hours == timetraihours)
                answer1 = 0 - 0;
            if (minutes > timetrainminutes)
                answer2 = (minutes - timetrainminutes);
            else if (minutes < timetrainminutes)
                answer2 = timetrainminutes - minutes;
            howmuchminutes = answer1 + answer2;
            Console.WriteLine("Минут к отправке :  " + howmuchminutes);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Train t = new Train("Kiev-Lvov", 141, 01, 17, 12);
            t.dannye();
            t.tableoftrains();
            Console.ReadLine();
        }
    }
}