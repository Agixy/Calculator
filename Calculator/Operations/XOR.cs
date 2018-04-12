using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class XOR : IOperation
    {
        public string Name => "XOR(^)";     // zostawiac te nawiasy?

        public double Calculate(int number1, int number2)
        {
            return number1 ^ number2;
        }
    }
}
