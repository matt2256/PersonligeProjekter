using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 0;
            double avg = 0;

            for (int i = 0; i < 10; i++)
            {
                
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }

                avg = sum / 10;
            Console.WriteLine(sum);
            Console.WriteLine(avg);

            Console.ReadKey(); 

        }
    }
}
