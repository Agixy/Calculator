using Infrastructure.Interfaces;
using System;

namespace HistoryLogger
{
    internal class HistoryUserComunication : IHistoryUserComunication
    {
        public void OperationErrorMessage()
        {
            Console.Error.WriteLine("Błąd operacji");
        }
    }
}
