using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryLogger
{
    public class HistoryUserComunication : IHistoryUserComunication
    {
        public string EnterPathToFile()
        {
            Console.WriteLine("Przed rozpoczęciem podaj ścieżkę gdzie chcesz zapisać historię operacji");
            string path = Console.ReadLine();
            return path;
        }
    }
}
