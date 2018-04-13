namespace Infrastructure.Interfaces
{
    public interface IOperation
    {
        string Name { get; }

        int Calculate(int number1, int number2);

    }
}