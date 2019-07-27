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
                            //Firkant / kasse- højde, længde, bredte
                            //indtastning
                            Console.Write("Indtast højde: ");
                            int heightSquareInput = int.Parse(Console.ReadLine());
                            Console.Write("Indtast Længden: ");
                            int lengthSquareInput = int.Parse(Console.ReadLine());
                            Console.Write("Indtast bredten: ");
                            int widthSquareInput = int.Parse(Console.ReadLine());

                            //objekt af square klassen
                            Square square = new Square(heightSquareInput, lengthSquareInput, widthSquareInput);

                            //udregning
                            Console.Write("Arealet af firkanten: ");
                            square.CalculateArea();
                            Console.Write("Rumfanget af kassen: ");
                            square.CalculateVolume();

                            break;
                        }
                    case 2:
                        {
                            //Trekant - højde, grundlinje, længde
                            //indtastning

                            //udregning
                            break;
                        }
                    case 3:
                        {
                            //Cirkel - radius
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
