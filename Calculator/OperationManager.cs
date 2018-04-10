using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OperationManager : IOperationManager
    {
        private readonly IOperation[] _operations;

        public OperationManager(IOperation[] operations)
        {
            _operations = operations;
        }

        public IOperation this[string n]
        {
            get { return _operations.First(g => g.Name == n); }
        }

        public string[] GetOperationsName()
        {
            return _operations.Select(o => o.Name).ToArray();
        }
    }
      
    
}
