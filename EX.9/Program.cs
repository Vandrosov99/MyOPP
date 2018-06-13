using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_9
{


    class Tochka
    {
        double a, b, c, d;
        public Tochka(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            Proverka1();
        }
        public void Proverka1()
        {
            if (a == b)
                Console.WriteLine("Это квадрат!");
            else
                Console.WriteLine("Это не квадрат!");
        }


        class DrawRec : Tochka
        {
            public DrawRec(double a, double b, double c, double d)
                : base(a, b, c, d)
            {

                Console.WriteLine("Perimeter = {0:.###} ", DiagonalWithPerimeter(a, b));
            }

            double DiagonalWithPerimeter(double x1, double x2)
            {
                Console.WriteLine("Diagonal = {0:.###}", Math.Sqrt(Diagonal(a, b)));
                return (a + b) * 2;

            }

            double Diagonal(double a, double b)
            {
                return Math.Pow(a, 2) + Math.Pow(b, 2);
            }


        }
        class Program
        {
            static void Main(string[] args)
            {
                new DrawRec(20, 20, 10, 10);
            }

        }
    }
}
    


