using Infrastructure.Interfaces;
using System;

namespace ErrorHandler
{
    internal class ErrorHandlerUserComunication : IErrorHandlerUserComunication
    {
        public void WriteError(string wrongOperationData)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Nie można wykonać operacji: {wrongOperationData}");
            Console.ResetColor();
        }
    }
}
