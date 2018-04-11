using System;

namespace Infrastructure.Interfaces
{
    public interface ICalculatorFlow
    {
        void Run();
        event EventHandler<OperationEventArgs> CalculatingFinished;

    }
}