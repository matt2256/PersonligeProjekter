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

            int k = 0;
            int j = 0;
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i*i*i);
            }

            Console.ReadKey();
        }
    }
}
