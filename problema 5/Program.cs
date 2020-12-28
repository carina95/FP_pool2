using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
            //Se considera ca primul element din secventa este pe pozitia 0. 

            int n, i, nr, eg;

            Console.WriteLine(" Cate numere doriti sa introduceti in secventa?");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            eg = 0;

            for (i = 0; i <= n; i++)
            {
                Console.Write("numarul {0}  = ", i);
                nr = int.Parse(Console.ReadLine());

                if (nr == i)
                {
                    eg++;
                }
            }

            Console.WriteLine($"In secventa data, {eg} numere sunt egale cu pozitia pe care apar.");
        }
    }
}
