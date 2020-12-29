using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determianti al n-lea numar din sirul lui Fibonacci.
            //Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). 
            //Exemplu: 0, 1, 1, 2, 3, 5, 8 ...

            int n, i, nr, nr1, nr2, nr3;

            Console.WriteLine(" Introduceti al cate-lea numar il cautati: ");
            Console.Write(" n = ");
            n = int.Parse(Console.ReadLine());

            nr1 = 0;
            nr2 = 1;
            nr3 = 0;

            for (i = 2; i < n; i++)
            {
                nr3 = nr1 + nr2;
                nr1 = nr2;
                nr2 = nr3;
            }

            Console.WriteLine($"Al {n}-lea numar din sirul Fibonacci este {nr3}. ");
        }
    }
}
