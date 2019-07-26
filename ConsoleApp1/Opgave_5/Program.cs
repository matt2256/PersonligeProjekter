using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast det første tal: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Indtast det andet tal: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num2);
            Console.WriteLine(num1);

            Console.ReadKey();
        }
    }
}
