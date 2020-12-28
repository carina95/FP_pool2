using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculati suma si produsul numerelor de la 1 la n. 

            int n, nr, i, suma, prod;

            suma = 0;
            prod = 0;

            Console.WriteLine(" Cate numere doriti sa introduceti in secventa?");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.Write("numarul {0}  = ", i);
                nr = int.Parse(Console.ReadLine());

                suma = suma + i;
                prod = prod + i;
            }

            Console.WriteLine($" Suma numerelor de la 1 la {n} este {suma}.");
            Console.WriteLine($" Produsul numerelor de la 1 la {n} este {prod}.");
        }
    }
}
