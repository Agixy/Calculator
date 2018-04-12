using Infrastructure.Interfaces;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistoryLogger;
using ErrorHandler;

namespace Calculator
{
    internal class CalculatorFlow : ICalculatorFlow
    {
        private readonly IOperationManager _operationManager;
        private readonly IUserComunication _userComunication;


        public CalculatorFlow(IOperationManager operationManager, IUserComunication userComunication)
        {
            _operationManager = operationManager;
            _userComunication = userComunication;

        }
    
        public OperationData OperationData { get => new OperationData(); set => new OperationData(); } /// po co te wyjatki????? 

        public event EventHandler<OperationEventArgs> CalculatingFinished;

        public void Run()
        {
            Console.Clear();

            var name = _userComunication.EnterName();
            List<string> operationsList = new List<string>();       // wydzielic jakoś do interfejsu IOperation?
           
            foreach (var operationName in _operationManager.GetOperationsName())
            {
                operationsList.Add(operationName);
            }

            int x = 0;
            do
            { 
                var choosenOperation = _operationManager[_userComunication.ChooseOperation(operationsList)];

                double result = 0;

                if (choosenOperation == null)
                {
                    _userComunication.WrongDataMessage();
                }
                else
                {
                    Func<int, int, double> operation = choosenOperation.Calculate;

                    var numbers = _userComunication.EnterNumbers();

                    result = operation(numbers.number1, numbers.number2);

                    _userComunication.ShowResult(result);


                    Console.ReadLine();

                    var operationData = new OperationData(choosenOperation.Name, result, numbers.number1, numbers.number2);
                    var eventArgs = new OperationEventArgs { OperationData = operationData };
                    CalculatingFinished?.Invoke(this, eventArgs);
                    x++;
                }

                //////////////////////////////////////////////////////////// FINISHED EVENT

               

            } while (x != 2);
          

        }
    }
}
