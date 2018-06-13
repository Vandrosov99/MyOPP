using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd15
{
    class Person
    {
        string pib;
        int zp, BYear;
        public Person(string pib, int zp, int BYear)
        {
            this.pib = pib;
            this.zp = zp;
            this.BYear =BYear;
            FindYear();
        }
    
        void FindYear()
        {
            if (DateTime.Today.Year - BYear < 50)
            {
                Console.WriteLine("Days to 50 = " + (50 - (DateTime.Today.Year - BYear)));
            }
            else
            {
                Console.WriteLine("Employeer over 50");
            }

        }
    }
    class EmpOfForm : Person
    {
        public string position;
        public EmpOfForm(string pib, int zp, int BYear, string position)
            : base(pib, zp, BYear)
        {
            this.position = position;
            Method(zp);
            Console.WriteLine("Oclad = " + zp);
        }

        void Method(int zp)
        {
            if (position.ToUpper().Equals("PROGRAMIST"))
            {
                int a = zp / 5;
                zp = zp + a;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EmpOfForm a = new EmpOfForm("X", 100, 1999, "programist");
        }
    }
}
