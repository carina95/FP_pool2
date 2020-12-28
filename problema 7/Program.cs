using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 

            int n, i, nr, mare, mic;

            Console.WriteLine(" Cate numere doriti sa aiba secventa? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            mare = -int.MaxValue;
            mic = int.MaxValue;

            for (i = 1; i <= n; i++)
            {
                Console.Write("numarul {0}  = ", i);
                nr = int.Parse(Console.ReadLine());

                if (nr > mare) mare = nr;
                if (nr < mic) mic = nr;
            }

            Console.WriteLine($"Cea mai mare valoare este {mare} si cea mai mica valoare este {mic}. ");
        }
    }
}
