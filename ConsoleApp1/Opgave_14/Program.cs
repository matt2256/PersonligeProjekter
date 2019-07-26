using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast et tal: ");
            int degree = int.Parse(Console.ReadLine());

            double kelv = degree + 273.15;
            double fhrenheight = degree * 1.8 + 32;

            Console.WriteLine(kelv);
            Console.WriteLine(fhrenheight);

            Console.ReadKey();
        }
    }
}
