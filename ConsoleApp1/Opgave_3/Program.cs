using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast dit første tal: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Indtast dit andet tal: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = 0;

            sum = num1 / num2;

            Console.WriteLine($"Summen når når tal et og tal 2 bliver divideret med hinanden er: {sum}");

            Console.ReadKey();
        }
    }
}
