using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast det første tal: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Indtast det andet tal: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Indtast det tredje tal: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Indtast det fjerde tal: ");
            int num4 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4;

            int avg = sum / 4;

            Console.WriteLine($"Gennemsnittet af tallene er: {avg}");

            Console.ReadKey();
        }
    }
}
