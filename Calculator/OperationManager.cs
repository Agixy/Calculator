using Infrastructure.Interfaces;
using System;
using System.Linq;

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
            get
            {
                try
                {
                    return  _operations.FirstOrDefault(g => g.Name == n);
                }
                catch (ArgumentNullException e)
                {
                    return null;
                }             
            }
        }

        public string[] GetOperationsName()
        {
            return _operations.Select(o => o.Name).ToArray();
        }
    }         
}
