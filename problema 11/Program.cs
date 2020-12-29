using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 

            int n, i, nr, aux, inv, suma;

            Console.WriteLine("Cate numere va contine secventa?");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());

            suma = 0;

            for (i = 1; i <= n; i++)
            {
                Console.Write("numarul {0}  = ", i);
                nr = int.Parse(Console.ReadLine());

                aux = nr;
                inv = 0;
                
                while (aux != 0)
                {
                    inv = inv * 10 + aux % 10;
                    aux = aux / 10;
                }
                suma = suma + inv;
            }
            Console.WriteLine($" Suma inverselor = {suma}. ");
        }
    }
}
