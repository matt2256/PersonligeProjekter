using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast dit første tal: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Indtast dit andet tal: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Indtast dit tredje tal: ");
            int num3 = int.Parse(Console.ReadLine());

            int resultat = num1 * num2 * num3;

            Console.WriteLine($"{num1} x {num2} x {num3} = {resultat}");

            Console.ReadKey();

        }
    }
}
