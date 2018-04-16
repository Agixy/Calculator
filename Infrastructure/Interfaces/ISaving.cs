using Infrastructure;

namespace Infrastructure.Interfaces
{
    public interface ISaving
    {
        bool AddOperationToFile(OperationData operation);
    }
}