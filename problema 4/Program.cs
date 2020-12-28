using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a. 
            //Se considera ca primul element din secventa este pe pozitia zero. 
            //Daca numarul nu se afla in secventa raspunsul va fi -1. 

            int n, nr, i, a, c;

            Console.WriteLine(" Cate numere doriti sa introduceti in secventa?");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine(" Ce numar doriti sa cautati in secventa?");
            Console.Write(" a = ");
            a = int.Parse(Console.ReadLine());

            c = -1 ; //contorul 

            for (i = 1; i <= n; i++)
            {
                Console.Write("numarul {0}  = ", i);
                nr = int.Parse(Console.ReadLine());

                if ( nr == a)
                {
                    c = i;
                }
            }

       

            Console.WriteLine($"Numarul {a} se afla pe pozitia {c} din secventa. ");
        }
    }
}
