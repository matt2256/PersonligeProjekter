using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateAreaGeometry
{
    class Square
    {
        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Height1 { get => height; set => height = value; }

        private int lenght;

        public int Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public int Lenght1 { get => lenght; set => lenght = value; }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Width1 { get => width; set => width = value; }

        public Square(int height, int lenght, int width)
        {
            this.height = height;
            this.lenght = lenght;
            this.width = width;
        }

        public void CalculateArea()
        {
            int area = height * lenght;
            Console.WriteLine($"Arealet af firkanten er: {area}");
        }

        public void CalculateVolume()
        {
            int volume = height * lenght * width;
            Console.WriteLine($"Rumfanget af kassen er: {volume}");
        }
    }
}
