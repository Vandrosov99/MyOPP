using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Chislo
    {
        int x, y;
        public Chislo(int x, int y)
        {
            this.x = x;
            this.y = y;
            Findchislo();
        }

        void Findchislo()
        {
            x += y;
            if (x < 0)
            {
                x *= -1;
            }
            Console.WriteLine("Число = " + x);

        }

        class Oxy : Chislo
        {
            public Oxy(int x, int x2, int y, int y2)
                : base(x, y)
            {
                Met(x, x2, y, y2);
            }

            void Met(int x, int x2, int y, int y2)
            {

                Console.WriteLine("Число = {0}", x + x2 + y + y2);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Oxy o = new Oxy(10, 20, 10, 20);

            }
        }
    }
}
