namespace Infrastructure
{
    public interface IOperationData
    {
        string Name { get; }
        int? Result { get; }
        int InputNumber1 { get; }
        int InputNumber2 { get; }
    }
}