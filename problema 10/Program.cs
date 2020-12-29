using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 

            int n, i, nr, a, max, c;

            Console.WriteLine(" Cate numere are secventa? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            a = int.Parse(Console.ReadLine());

            max = 0;
            c = 1;

            for (i = 1; i <= n; i++)
            {
                Console.Write("numarul {0}  = ", i);
                nr = int.Parse(Console.ReadLine());

                if (a == nr)
                    c++;
                else
                    c = 1;
                if (c >= max)
                    {
                        max = c;
                        a = nr;
                    }                    
            }
            Console.WriteLine($" Numarul maxim de numere consecutive egale din secventa este {max}. ");
        }
    }
}
