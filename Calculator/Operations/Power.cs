using Infrastructure.Interfaces;
using System;

namespace Calculator.Operations
{
    class Power : IOperation
    {
        public string Name => "Potęguj";

        public int Calculate(int number1, int number2)
        {
            if(number1 == 0 && number2 == 0)
            {
                throw new InvalidOperationException("Nie można podnieść 0 do potęgi 0");
            }
            return (int)Math.Pow(number1, number2);
        }        
    }
}
