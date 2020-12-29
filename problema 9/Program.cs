using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sa se determine daca o secventa de n numere este monotona. 
            //Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 

            int n, i, nr, a, cre, desc;

            Console.WriteLine(" Acest program determina daca o secventa de n numere este monotona. ");

            Console.WriteLine(" Cate numere va avea secventa? ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            cre = 0;
            desc = 0;

            if (n > 1)
            {
                    nr = int.Parse(Console.ReadLine());

                    for (i = 1; i <= n - 1; i++)
                    {

                        a = int.Parse(Console.ReadLine());

                        if (a >= nr)
                            desc++;

                        if (a <= nr)
                            cre++;

                        nr = a;
                    }
                }
            else
                Console.WriteLine(" Introduceti mai multe numere. ");

            if (desc == 0)
                Console.WriteLine("Sirul este monoton descrescator.");
            else
            {
                if (cre == 0)
                    Console.WriteLine("Sirul este monoton crescator.");
                else
                    Console.WriteLine("Sirul nu este monoton. ");
            }
        }
    }
}