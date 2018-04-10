namespace Infrastructure.Interfaces
{
    public interface IOperationManager
    {
        string[] GetOperationsName();
        IOperation this[string n] { get; }
    }
}