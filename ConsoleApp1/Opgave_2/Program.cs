using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Indtast det første tal: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Indtast det andet tal: ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = 0;

            sum = num1 + num2;

            Console.WriteLine($"Summen af de to tal er: {sum}");

            Console.ReadKey();
        }
    }
}
