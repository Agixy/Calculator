using Calculator;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class CalculatorFlow : ICalculatorFlow
    {
        private readonly IOperationProvider _operationProvider;

        public CalculatorFlow(IOperationProvider operationProvider)
        {
            _operationProvider = operationProvider;
        }


        internal void Run()
        {
            Console.Clear();

            var userComunication = new UserComunication();

            var name = userComunication.EnterName();

            List<string> operationsList = new List<string>();       // wydzielic jakoś do interfejsu?
           
            foreach (var operationName in _operationProvider.GetOperationsName())
            {
                operationsList.Add(operationName);
            }

            var operation = _operationProvider[userComunication.ChooseOperation(operationsList)];

        }
    }
}
