using Infrastructure;
using Infrastructure.Interfaces;
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

        public Logger(List<OperationData> operationsList, int howMany, ICalculatorFlow flow)
        {
            _operationsList = operationsList;
            _howMany = howMany;
            flow.CalculatingFinished += Flow_CalculatinFinished;
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
