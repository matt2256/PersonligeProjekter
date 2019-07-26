using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            int z = 7;

            //1)(x+y).z  2)x.y + y.z.
            Console.Write("Første: ");
            Console.WriteLine((x+y)*z);
            Console.Write("andet: ");
            Console.WriteLine((x*y)+(y*z));

            Console.ReadKey();
        }
    }
}
