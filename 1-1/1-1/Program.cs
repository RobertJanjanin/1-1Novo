using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Proc x = new Proc();

            Obj y = new Obj();

            Funk z = new Funk();

            Console.WriteLine("Upisite postotak za proceduralni tip: ");
            x.Postotak = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Upisite postotak za objektni tip: ");
            y.Postotak = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Upisite postotak za funkcionalni tip: ");
            z.Postotak = Convert.ToDouble(Console.ReadLine());

            if (x.Postotak + y.Postotak + z.Postotak != 100)
                {
                Console.WriteLine("Uneseni podaci su netocni");
                  }
            else
            {

                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najzatupljeniji tip je proceduralni.");
                }

                else if (y.Postotak > z.Postotak)
                {
                    Console.WriteLine("Najzatupljeniji tip je objektni");
                }

                else
                {
                    Console.WriteLine("Najzatupljeniji tipje funkcionalni");
                }
            }

            Console.ReadKey();
        }
    }
}
