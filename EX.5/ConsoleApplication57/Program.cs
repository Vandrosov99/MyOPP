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
        public int allminutes;
        public void dannye()
        {

            Console.WriteLine("hours");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("minutes");
            minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("seconds");
            seconds = Convert.ToInt32(Console.ReadLine());
            allminutes = 60 * hours + minutes;
            Console.WriteLine("Повних хвилин в заданому часі : " + allminutes);
            Console.ReadLine();
            Console.WriteLine("Time: {0}:{1}:{2}", hours, minutes, seconds);
            Console.Read();
        }
    }
    class Abonent : Time
    {
        string pib;
        string operAtor;
        int Asec, Ahours, Aminutes;
        public Abonent(string pib, string operAtor, int Ahours, int Aminutes, int Asec)
        {
            this.pib = pib;
            this.operAtor = operAtor;
            this.Ahours = Ahours;
            this.Aminutes = Aminutes;
            this.Asec = Asec;
        }
        public void abonent()
        {
            Console.WriteLine("Время абонента : " + Ahours + "часов " + Aminutes + "минут " + Asec + "секунд ");

            if (Ahours > 0 && Ahours < 8)
                Console.WriteLine(" Вы попадаете в льготное время ! ");
            else
                Console.WriteLine("Вы не попадаете в льготное время ! ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abonent a = new Abonent("Androsov Volodymyr Andriovich", "asd", 04, 12, 35);
            a.dannye();
            a.abonent();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}