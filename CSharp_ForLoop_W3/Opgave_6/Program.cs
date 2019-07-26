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
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i *num);
            }

            Console.ReadKey();
        }
    }
}
