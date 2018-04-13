using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class Multiply : IOperation
    {
        public string Name => "Pomnóż";

      
        public int Calculate(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
