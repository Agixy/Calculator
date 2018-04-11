namespace Infrastructure
{
    public interface IOperationData
    {
        string Name { get; }

        double Result { get; }

        int[] InputNumbers { get; }
    }
}