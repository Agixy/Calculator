namespace Infrastructure.Interfaces
{
    public interface IOperation
    {
        string Name { get; }

        int Number1 { get; set; }
        int Number2 { get; set; }

        int Calculate(int number1, int number2);

    }
}