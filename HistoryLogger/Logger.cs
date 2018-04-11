using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryLogger
{
    public class Logger : ILogger
    {
        List<OperationData> _operationsList = new List<OperationData>();
        private readonly int _howMany;

        public Logger(List<OperationData> operationsList, int howMany)
        {
            _operationsList = operationsList;
            _howMany = howMany;
        }

        private void Flow_CalculatinFinished(object sender, OperationEventArgs e)
        {
            Add(e.OperationData);
        }

        public OperationData[] List()
        {
            return _operationsList.ToArray();
        }


        public void Add(OperationData data)
        {
            _operationsList.Add(data);
        }

    }
}
