using Infrastructure.Interfaces;

namespace Calculator.Operations
{
    class OR : IOperation
    {
        public string Name => "OR";

        public int Calculate(int number1, int number2)
        {
            return number1 | number2;
        }
    }
}
