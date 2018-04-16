using Infrastructure.Interfaces;

namespace Calculator.Operations
{
    class XOR : IOperation
    {
        public string Name => "XOR";  

        public int Calculate(int number1, int number2)
        {
            return number1 ^ number2;
        }
    }
}
