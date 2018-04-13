using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class Divide : IOperation
    {
        public string Name => "Podziel";
    
        public int Calculate(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new InvalidOperationException("Nie można dzielić przez 0");       // czy to też ma być na czerwono?
            }                           
            return number1 / number2;
        }
    }
}
