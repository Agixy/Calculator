using Infrastructure;
using Infrastructure.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryLogger
{
    class Saving : ISaving
    {
        private const string pathToFile = "OperationsHistory.csv";
        private readonly IHistoryUserComunication _historyUserComunication;
       // private readonly ILogger _logger;

        public Saving(IHistoryUserComunication historyUserComunication)//,ILogger logger)
        {
            _historyUserComunication = historyUserComunication;
            //_logger = logger;
        }
        
        //public void CreateFile()
        //{
        //    string path = _historyUserComunication.EnterPathToFile();

        //   string pathToFile = Path.Combine(path, "OperationsHistory.csv");

        //   File.Create(pathToFile);
        //}

        public bool AddOperationToFile(OperationData operation)         // Robic dodawanie tytułów(nagłówek całego pliku)? Z ręki czy jest jakis sposób?
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(operation.ToCSV());

                File.AppendAllText(pathToFile, sb.ToString());
                return true; // czy wykona sie jak wyzej bedzie błąd?
            }
            catch(Exception e)
            {
                return false;
            }
        }      
    }
}
