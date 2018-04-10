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
        private readonly IOperationManager _operationManager;

        public CalculatorFlow(IOperationManager operationManager)
        {
            _operationManager = operationManager;
        }

        public void Run()
        {
            Console.Clear();

            var userComunication = new UserComunication();

            var name = userComunication.EnterName();

            List<string> operationsList = new List<string>();       // wydzielic jakoś do interfejsu IOperation?
           
            foreach (var operationName in _operationManager.GetOperationsName())
            {
                operationsList.Add(operationName);
            }

            var choosenOperation = _operationManager[userComunication.ChooseOperation(operationsList)];

            Func<int, int, int> operation = choosenOperation.Calculate;

            var numbers = userComunication.EnterNumbers();

            int number1 = numbers.number1;
            int number2 = numbers.number2;

            // Czemu nie da się tak: int result = operation(userComunication.EnterNumbers());  ??????????????

            int result = operation(number1, number2);

            userComunication.ShowResult(result);

            Console.ReadLine();

        }
    }
}
