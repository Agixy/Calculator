using Infrastructure.Interfaces;

namespace Calculator.Operations
{
    class Add : IOperation
    {
        public string Name => "Dodaj";

        public int Calculate(int number1, int number2)   
        {
            return number1 + number2;
        }              
    }
}
