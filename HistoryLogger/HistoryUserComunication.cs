using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
