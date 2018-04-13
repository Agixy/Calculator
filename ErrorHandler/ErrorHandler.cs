using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistoryLogger;
using Infrastructure;
using Infrastructure.Interfaces;

namespace ErrorHandler
{
    public class ErrorHandler : IErrorHandler     
    {                               // dzielenie i potega moze miec blad -> maja rzucac event zamiast wyjatu. try catch -> event
        private readonly ICalculatorFlow _flow;

        public ErrorHandler(ICalculatorFlow flow)
        {
            _flow = flow;
            flow.CalculatingError += WriteErrors;
        }
  
        private void WriteErrors(object sender, OperationEventArgs operationEventArgs)
        {
            Console.WriteLine($"Nie można wykonać operacji: {operationEventArgs.OperationData}");    // na czerowno
        }
    }                               

}
