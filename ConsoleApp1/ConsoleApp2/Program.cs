using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast et tal: "); 
            int num1 = int.Parse(Console.ReadLine());

            int a = num1 * 1;
            int b = num1 * 2;
            int c = num1 * 3;
            int d = num1 * 4;
            int e = num1 * 5;
            int f = num1 * 6;
            int g = num1*7;
            int h = num1*8;
            int i = num1*9;
            int j = num1*10;
;
             

            Console.WriteLine($"{num1} x 1 = {a}");
            Console.WriteLine($"{num1} x 2 = {b}");
            Console.WriteLine($"{num1} x 3 = {c}");
            Console.WriteLine($"{num1} x 4 = {d}");
            Console.WriteLine($"{num1} x 5 = {e}");
            Console.WriteLine($"{num1} x 6 = {f}");
            Console.WriteLine($"{num1} x 7 = {g}");
            Console.WriteLine($"{num1} x 8 = {h}");
            Console.WriteLine($"{num1} x 9 = {i}");
            Console.WriteLine($"{num1} x 10 = {j}");

            Console.ReadKey();
        }
    }
}
