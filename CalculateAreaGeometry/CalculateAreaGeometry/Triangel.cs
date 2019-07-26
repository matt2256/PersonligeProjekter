using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateAreaGeometry
{
    class Triangel
    {
        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Height1 { get => height; set => height = value; }

        private int baseline;

        public int Baseline
        {
            get { return baseline; }
            set { baseline = value; }
        }

        public int Baseline1 { get => baseline; set => baseline = value; }

        private int lenght;

        public int Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public int Lenght1 { get => lenght; set => lenght = value; }

        public Triangel (int height, int baseline, int lenght)
        {
            this.height = height;
            this.baseline = baseline;
            this.lenght = lenght;
        }

        public void CalculateArea()
        {
            double area = 0.5 * height * baseline;
            Console.WriteLine($"Arealet af trekanten er: {area}");
        }

        public void CalculateVolume()
        {
            double volume = 0.33 * height * baseline;
            Console.WriteLine($"Rumfanget af pyramiden: {volume}");
        }
    }
}
