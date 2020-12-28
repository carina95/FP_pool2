using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 

            int n, i, nr, x;
            bool cresc = true;

            Console.WriteLine(" Cate numere doriti sa introduceti in secventa?");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            nr = 0;

            for (i = 1; i <= n; i++)
            {
                x = nr;

                Console.Write("numarul {0}  = ", i);
                nr = int.Parse(Console.ReadLine());

                if ( nr < x ) cresc = false; 
            }
            
            if (cresc == true)
                Console.WriteLine("Numerele din secventa sunt in ordine crescatoare");
            else
               Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare");
        }
    }
}
