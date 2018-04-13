using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class Substract : IOperation
    {
        public string Name => "Odejmij";
      
        public int Calculate(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
