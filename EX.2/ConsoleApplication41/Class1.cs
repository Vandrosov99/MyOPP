using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Date
    {
        public int year = 1999;
        public int month = 02;
        public int day = 02;
         public void kratnost()
        {

            Console.WriteLine("До : " + year);
            year += 1;
            Console.WriteLine("После : " + year);
        

        }
    }
}

