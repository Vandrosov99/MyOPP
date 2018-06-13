using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Pryamokytnik
    {
        int x1, y1, x2, y2;
        public Pryamokytnik(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            if (x1 != y2 || y1 != x2)
                NotRectangle();
            else
                Diagonale();
        }

        void Diagonale()
        {
            Console.WriteLine(" Диагональ вашего прямоугольника = " + (x1 + y1) * 2);
        }
        void NotRectangle()
        {
            Console.WriteLine("Это не прямоугольник");
        }
    }

    class Kryg : Pryamokytnik
    {
        double radius = 0;
        double x1, y1;
        public Kryg(int x1, int y1, int x2, int y2, double radius)
            : base(x1, y1, x2, y2)
        {
            this.radius = radius;
            this.x1 = x1;
            this.y1 = y1;
            double sqrFig = SquareOfpryamokytnik() - SquareOfKryg();
            Console.WriteLine("Площа вашей фигуры равна  = " + sqrFig);

        }

        double SquareOfpryamokytnik()
        {
            return (x1 + y1) * 2;
        }

        double SquareOfKryg()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            Kryg k = new Kryg(5, 3, 3, 5, 1);
            Console.ReadLine();
        }
    }
}
