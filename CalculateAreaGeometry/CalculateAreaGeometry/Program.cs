using System;

namespace CalculateAreaGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Udregning af areal og rumfang");
            Console.WriteLine("1) Frikant / Kasse");
            Console.WriteLine("2) Trekant / Pyramide");
            Console.WriteLine("3) Cirkel / Kugle ");
            Console.WriteLine("4) Afslut");

            Console.Write("Dit svar: ");
            int choice = int.Parse(Console.ReadLine());

            while (true)
            {
                switch (choice)
                {
                    case 1:
                        {
                            //indtastning

                            //udregning
                            break;
                        }
                    case 2:
                        {
                            //indtastning

                            //udregning
                            break;
                        }
                    case 3:
                        {
                            //indtastning

                            //udregning
                            break;
                        }
                    case 4:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
    }
}
