using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Tochka
    {
        int a, c,b, d;

        public Tochka(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;

            Sqr();
        }

        void Sqr()
        {
            Console.WriteLine("Площа прямоугольника равна  = " + a * b);
        }
    }

    class Convert : Tochka 
    {
        int a, b, c, d;
        public Convert(int a, int b, int c, int d)
            : base(a, b, c, d)
        { 
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            Con();


        }


        void Con()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            double z = a / 5;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < b / 2; j++)
                {
                    Otstup();
                }

                Console.WriteLine("*");
            }
            for (int j = 0; j < z; j++)
            {
                Enter();
            }


            for (int i = 0; i < 1; i++)
            {
                Console.Write("*");
                for (int j = 0; j < b - 2; j++)
                {
                    Otstup();
                }
                Console.Write("*");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < b; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                Console.Write("*");
                for (int j = 0; j < b - 2; j++)
                {
                    Otstup();
                }
                Console.Write("*");
                Console.WriteLine();
            }

            for (int i = 0; i < b; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            SqrtOfTrikytnik();
        }

        void Otstup()
        {
            Console.Write(" ");
        }
        void Enter()
        {
            Console.WriteLine();
        }
        void SqrtOfTrikytnik()
        {
            Console.WriteLine("Площа прямоугольника = " + (a + b + c + d) * 0.1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Convert c = new Convert(5, 3, 3, 5);
        }
    }
}

