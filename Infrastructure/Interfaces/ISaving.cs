using Infrastructure;

namespace HistoryLogger
{
    public interface ISaving
    {
       // void CreateFile();
        void AddOperationToFile(OperationData operation);
    }
}