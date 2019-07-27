using System;

namespace CalculateAreaGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Udregning af areal og rumfang");
                Console.WriteLine("1) Frikant / Kasse");
                Console.WriteLine("2) Trekant / Pyramide");
                Console.WriteLine("3) Cirkel / Kugle ");
                Console.WriteLine("4) Afslut");

                Console.Write("Dit svar: ");
                int choice = int.Parse(Console.ReadLine());

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
                            Console.Write("Indtast højden af trekanten: ");
                            int heightTriInput = int.Parse(Console.ReadLine());
                            Console.Write("Indtast grundlinjen af trekanten: ");
                            int baselineTriInput = int.Parse(Console.ReadLine());
                            Console.Write("Indtast længden af trekanten: ");
                            int lengthTriInput = int.Parse(Console.ReadLine());

                            //objekt af klasssen
                            Triangel triangel = new Triangel(heightTriInput, baselineTriInput, lengthTriInput);

                            //udregning
                            Console.Write("Arealet af trekanten: ");
                            triangel.CalculateArea();
                            Console.Write("Rumfanget af pyramiden: ");
                            triangel.CalculateVolume();
                            break;
                        }
                    case 3:
                        {
                            //Cirkel - radius
                            //indtastning
                            Console.Write("Indtast radiussen: ");
                            int radius = int.Parse(Console.ReadLine());

                            //objekt af klassen
                            Cirkel cirkel = new Cirkel(radius);

                            //udregning
                            Console.Write("Arealet af cirkel: ");
                            cirkel.CalculateArea();
                            Console.Write("Rumfanget af kuglen: ");
                            cirkel.CalculateVolume();
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
