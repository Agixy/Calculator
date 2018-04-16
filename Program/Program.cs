using Calculator;
using HistoryLogger;
using Infrastructure.Interfaces;
using Ninject;
using ErrorHandler;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel container = new StandardKernel(new CalculatorModule(), new ProgramModule(), new HistoryLoggerModule(), new ErrorHandlerModule());

            var flow = container.Get<ICalculatorFlow>();
            var logger = container.Get<ILogger>();
            var error = container.Get<IErrorHandler>();

            flow.Run();
        }
    }
}
