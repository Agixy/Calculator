namespace Infrastructure.Interfaces
{
    public interface IOperation
    {
        string Name { get; }

        double Calculate(int number1, int number2);

    }
}