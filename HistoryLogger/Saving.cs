using Infrastructure;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryLogger
{
    internal class Saving : ISaving
    {
        private const string pathToFile = "OperationsHistory.csv";
        private readonly IHistoryUserComunication _historyUserComunication;

        public Saving(IHistoryUserComunication historyUserComunication)
        {
            _historyUserComunication = historyUserComunication;
        }
        
        public bool AddOperationToFile(OperationData operation)
        {
            try
            {
                File.AppendAllText(pathToFile, operation.ToCSV() + Environment.NewLine);
                return true; 
            }
            catch(Exception e)
            {
                return false;
            }
        }      
    }
}
