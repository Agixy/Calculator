using Infrastructure;
using Infrastructure.Interfaces;

namespace ErrorHandler
{
    public class ErrorHandler : IErrorHandler     
    {                              
        private readonly ICalculatorFlow _flow;
        private readonly IErrorHandlerUserComunication _errorUserComunication;

        public ErrorHandler(ICalculatorFlow flow, IErrorHandlerUserComunication errorUserComunication)
        {
            _flow = flow;
            _errorUserComunication = errorUserComunication;
            flow.CalculatingError += WriteErrors;
        }
  
        private void WriteErrors(object sender, OperationEventArgs operationEventArgs)
        {
            _errorUserComunication.WriteError(operationEventArgs.OperationData.ToString());
        }
    }                               
}
