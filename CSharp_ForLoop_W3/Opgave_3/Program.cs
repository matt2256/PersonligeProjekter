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
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum = sum + i;
                Console.WriteLine(i);
            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
