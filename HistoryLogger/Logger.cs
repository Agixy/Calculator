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
        public readonly ISaving _saving;

        List<OperationData> _operationsList = new List<OperationData>();
        //private readonly int _howMany;

        public Logger(ICalculatorFlow flow, ISaving saving)
        {
            flow.CalculatingFinished += Flow_CalculatingFinished;
            _saving = saving;
        }

        private void Flow_CalculatingFinished(object sender, OperationEventArgs e)
        {
            Add(e.OperationData);
            bool correctOperation = _saving.AddOperationToFile(e.OperationData);

            if(!correctOperation)
            {
                SignOffEvent();            
                Console.Error.WriteLine("Błąd operacji");   // czy o to chodzi ???????????????????????????????????????? W USerComun?
            }

        }

        void SignOffEvent()
        {
            // jak sie wypisać ????????
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
