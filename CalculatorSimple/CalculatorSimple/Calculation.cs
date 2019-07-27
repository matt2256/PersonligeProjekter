using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorSimple
{
    class Calculation
    {
        private int firstNumber;

        public int FirstNumber
        {
            get { return firstNumber; }
            set { firstNumber = value; }
        }

        public int FirstNumber1 { get => firstNumber; set => firstNumber = value; }

        private int secoundNumber;

        public int SecoundNumber
        {
            get { return secoundNumber; }
            set { secoundNumber = value; }
        }

        public int SecoundNumber1 { get => secoundNumber; set => secoundNumber = value; }

        public Calculation(int firstNumber, int secoundNumber)
        {
            this.firstNumber = firstNumber;
            this.secoundNumber = secoundNumber;
        }

        public void Addition()
        {
            int sum = firstNumber + secoundNumber;
            Console.WriteLine($"Addition: {firstNumber} + {secoundNumber} = {sum}");
        }

        public void Subtraction()
        {
            int sum = firstNumber - secoundNumber;
            Console.WriteLine($"Subtraction: {firstNumber} - {secoundNumber} = {sum}");
        }

        public void Multiplication()
        {
            int sum = firstNumber * secoundNumber;
            Console.WriteLine($"Multiplication: {firstNumber} * {secoundNumber} = {sum}");
        }

        public void Division()
        {
            int sum = firstNumber / secoundNumber;
            Console.WriteLine($"Division: {firstNumber} * {secoundNumber} = {sum}");
        }
    }
}
