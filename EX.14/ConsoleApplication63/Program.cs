using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Book
    {
        string pib;
        int zp, Ywork, Mwork, Dwork, Ynow, Mnow, Dnow;
        int findyear, findmonth, finddays, answer;
        public Book(string pib, int zp, int Ywork, int Mwork, int Dwork, int Ynow, int Mnow, int Dnow)
        {
            this.pib = pib;
            this.zp = zp;
            this.Ywork = Ywork;
            this.Mwork = Mwork;
            this.Dwork = Dwork;
            this.Ynow = Ynow;
            this.Mnow = Mnow;
            this.Dnow = Dnow;
            DaysAgo();
        }
        public void DaysAgo()
        {
           
              findyear = (Ynow - Ywork) * 365;
             if (Mwork > Mnow)
                findmonth = (Mwork - Mnow) * 30;
            else if (Mwork < Mnow)
                findmonth = (Mnow - Mwork) * 30;
            else if (Dwork < Dnow)
                finddays = Dnow - Dwork;
            else
                finddays = Dwork - Dnow;
            Console.WriteLine("Дней прошло после вступление на работу :  " + findyear + findmonth + finddays);
          

        }
        class Book2 : Book
        {
            int Byear, Bmonth, Bday, findyear2;
            public Book2(string pib, int zp, int Ywork, int Mwork, int Dwork, int Ynow, int Mnow, int Dnow, int Byear, int Bmonth, int Bday) : base(pib, zp, Ywork, Mwork, Dwork, Ynow, Mnow, Dnow)
            {
                this.Byear = Byear;
                this.Bmonth = Bmonth;
                this.Bday = Bday;
                HowmuchYears();
              
            }

            public void HowmuchYears()
            {    

                findyear2 = Ynow - Ywork;
                if (findyear2 < 60)
                    findyear2 = 60 - findyear2;
                Console.WriteLine("нужно еще работать : " + findyear2);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Book2 b = new Book2("A.V.V", 5000, 2000, 02, 02, 2016, 02, 02, 1980, 02, 02);
                
            }
        }
    }
}
