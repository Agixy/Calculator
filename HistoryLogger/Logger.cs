using Infrastructure;
using Infrastructure.Interfaces;

namespace HistoryLogger
{
    internal class Logger : ILogger
    {
        private readonly ICalculatorFlow _flow;
        private readonly ISaving _saving;
        private readonly IHistoryUserComunication _historyUserComunication;

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
            _historyUserComunication.OperationErrorMessage();
        }

        private void SignOffEvent()
        {
            _flow.CalculatingFinished -= Flow_CalculatingFinished;
        }   
    }
}
