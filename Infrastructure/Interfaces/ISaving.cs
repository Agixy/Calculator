using Infrastructure;

namespace HistoryLogger
{
    public interface ISaving
    {
       // void CreateFile();
        bool AddOperationToFile(OperationData operation);
    }
}