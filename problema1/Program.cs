using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //se da o secventa de n numere.Sa se determine cate din ele sunt pare. 

            int n, nr, i, par;

            Console.WriteLine("Cate numere doriti sa introduceti in secventa?");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            par = 0;

            for (i = 1; i <= n; i++)
            {
                Console.Write("numarul {0}  = ", i);
                nr = int.Parse(Console.ReadLine());

                if (nr % 2 == 0)
                    par++;
            }
                         
            Console.WriteLine($"In secventa sunt {par} numere pare.");
        }
    }
}
