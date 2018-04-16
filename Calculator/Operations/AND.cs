using Infrastructure.Interfaces;

namespace Calculator.Operations
{
    class AND : IOperation
    {
        public string Name => "AND";

        public int Calculate(int number1, int number2)
        {
            return number1 & number2;
        }
    }
}
