using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateAreaGeometry
{
    class Cirkel
    {
        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public int Radius1 { get => radius; set => radius = value; }

        public Cirkel(int radius)
        {
            this.radius = radius;
        }

        public void CalculateArea()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Radiusen på cirklen er: {area}");
        }

        public void CalculateVolume()
        {
            double volume = 1.33 * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Rumfanget af kuglen er: {volume}");
        }
    }
}
