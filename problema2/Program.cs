using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. 
            //Sa se determine cate sunt negative, cate sunt zero si cate sunt pozitive. 

            int n, nr, i, neg, zero, poz;

            Console.WriteLine("Cate numere doriti sa introduceti in secventa?");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            neg = 0;
            poz = 0;
            zero = 0;


            for (i = 1; i <= n; i++)
            {
                Console.Write("numarul {0}  = ", i);
                nr = int.Parse(Console.ReadLine());

                if (nr < 0)
                    neg++;
                if (nr == 0)
                    zero++;
                if (nr > 0)
                    poz++;
            }

            Console.WriteLine($"In secventa sunt {neg} numere negative. ");
            Console.WriteLine($"In secventa sunt {zero} numere egale cu 0. ");
            Console.WriteLine($"In secventa sunt {poz} numere pozitive. ");
        }
    }
}
