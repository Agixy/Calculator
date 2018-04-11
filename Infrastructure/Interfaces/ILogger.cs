using Infrastructure;
using System.Collections.Generic;

namespace HistoryLogger
{
    public interface ILogger
    {
        
       OperationData[] List();
       void Add(OperationData oper);
    }
}