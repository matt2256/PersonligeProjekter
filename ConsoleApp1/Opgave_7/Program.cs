using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast det første tal: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Indtast det andet tal: ");
            int num2 = int.Parse(Console.ReadLine());

            int add = num1 + num2;
            int minus = num1 - num2;
            int multiply = num1 * num2;
            int divide = num1 / num2;

            Console.WriteLine($"Pluds: {num1} + {num2} = {add}");
            Console.WriteLine($"Minus: {num1} - {num2} = {minus}");
            Console.WriteLine($"Multiply: {num1} * {num2} = {multiply}");
            Console.WriteLine($"Divide: {num1} / {num2} = {divide}");

            Console.ReadKey();
        }
    }
}
