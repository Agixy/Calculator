using Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryLogger
{
    class Saving
    {
        // utworzyć plik

        void SerializeOperations(List<OperationData> list)
        {
            var json = JsonConvert.SerializeObject(list);
        }
    }
}
