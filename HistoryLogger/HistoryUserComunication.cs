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
            string path = Console.ReadLine();
            return path;
        }
       
    }
}
