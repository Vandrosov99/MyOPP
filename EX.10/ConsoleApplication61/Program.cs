using ConsoleApplication57;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication57
{
    class Fraction1
    {
        int sum = 0;
        int chiselnik;
        int znamennik;
        public Fraction1(int chiselnik, int znamennik)
        {
            this.chiselnik = chiselnik;
            this.znamennik = znamennik;
        }
        public void Sumofznam()
        {
            while (znamennik != 0)
            {
                sum += znamennik % 10;
                znamennik /= 10;
            }
            Console.WriteLine("Сумма цифр в знаменателе = " + sum);
        }

    }
    class Fraction2 : Fraction1
    {
        int entireDrib;
        public Fraction2(int entireDrib, int chiselnic, int znamennik)
            : base(chiselnic, znamennik)
        {

            this.entireDrib = entireDrib;

            FindFraction(entireDrib, chiselnic, znamennik);
        }

        void FindFraction(double entireDrib, double chiselnic, double znamennik)
        {
            double mishane = (entireDrib * znamennik + chiselnic) / znamennik;
            Console.WriteLine("Mishane choslo = " + mishane);
        }
    }

}
class Program
{
    static void Main(string[] args)
    {

        Fraction2 f = new Fraction2(1, 5, 5);
        f.Sumofznam();
    }
}

