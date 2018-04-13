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
        private readonly ICalculatorFlow _flow;
        private readonly ISaving _saving;

        public Logger(ICalculatorFlow flow, ISaving saving)
        {
            flow.CalculatingFinished += Flow_CalculatingFinished;
            _flow = flow;
            _saving = saving;
        }

        private void Flow_CalculatingFinished(object sender, OperationEventArgs e)
        {
            bool correctOperation = _saving.AddOperationToFile(e.OperationData);

            if (correctOperation)
                return;
            SignOffEvent();            
            Console.Error.WriteLine("Błąd operacji");   // do userCom
        }

        void SignOffEvent()
        {
            _flow.CalculatingFinished -= Flow_CalculatingFinished;
        }

     

    }
}
