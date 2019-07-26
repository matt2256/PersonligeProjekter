using System;

namespace EX06Selection_6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int vægt = int.Parse(Console.ReadLine());
            string ekspress = Console.ReadLine();
            double pris = 1.5;
            if (vægt <= 20)
            {
                if (ekspress == "ja")
                {
                    Console.WriteLine(5 * pris);
                }
                else
                {
                    Console.WriteLine("Det kommer til at koste 5kr");
                }
            }
            else if (vægt >= 20 && vægt < 50)
            {
                if (ekspress == "ja")
                {
                    Console.WriteLine(7 * pris);
                }
                else
                {
                    Console.WriteLine("Det kommer til at koste 7kr");
                }
            }
            else if (vægt >= 50 && vægt < 100)
            {
                if (ekspress == "ja")
                {
                    Console.WriteLine(10 * pris);
                }
                else
                {
                    Console.WriteLine("Det kommer til at koste 10kr");
                }
            }
            else if (vægt >= 100 && vægt < 150)
            {
                if (ekspress == "ja")
                {
                    Console.WriteLine(15 * pris);
                }
                else
                {
                    Console.WriteLine("Det kommer til at koste 15kr");
                } 
            }
            else if (vægt >= 150 && vægt < 200)
            {
                if (ekspress == "ja")
                {
                    Console.WriteLine(20 * pris);
                }
                else
                {
                    Console.WriteLine("Det kommer til at koste 20kr");
                }
            }else
            {
                if (ekspress == "ja")
                {
                    Console.WriteLine(30 * pris);
                }
                else
                {
                    Console.WriteLine("Det kommer til at koste 30kr");
                }
            }
            Console.ReadKey();
        }
    }
}
