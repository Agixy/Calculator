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

      
        public double Calculate(int number1, int number2)
        {
            return (double)number1 / number2;
        }
    }
}
