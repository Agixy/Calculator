using Infrastructure.Interfaces;
using System;

namespace Calculator.Operations
{
    class Divide : IOperation
    {
        public string Name => "Podziel";
    
        public int Calculate(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new InvalidOperationException("Nie można dzielić przez 0");
            }                           
            return number1 / number2;
        }
    }
}
