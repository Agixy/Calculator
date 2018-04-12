using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class Power : IOperation
    {
        public string Name => "Potęguj";

        public double Calculate(int number1, int number2)
        {
            return Math.Pow(number1, number2);
        }        
    }
}
