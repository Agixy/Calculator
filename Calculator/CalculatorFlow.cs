using Infrastructure.Interfaces;
using Infrastructure;
using System;
using System.Collections.Generic;

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

        public event EventHandler<OperationEventArgs> CalculatingFinished;
        public event EventHandler<OperationEventArgs> CalculatingError;

        public void Run()
        { 
            List<string> operationsList = new List<string>();
           
            foreach (var operationName in _operationManager.GetOperationsName())
            {
                operationsList.Add(operationName);
            }

            do
            {
                Console.Clear();
                var choosenOperation = _operationManager[_userComunication.ChooseOperation(operationsList)];
               
                if (choosenOperation == null)
                {
                    _userComunication.WrongDataMessage();
                }
                else
                {
                    Func<int, int, int> operation = choosenOperation.Calculate;
                    var numbers = _userComunication.EnterNumbers();

                    try 
                    {                     
                        int result = operation(numbers.number1, numbers.number2);
                         _userComunication.ShowResult(result);                      
                        
                        var operationData = new OperationData(choosenOperation.Name, result, numbers.number1, numbers.number2);
                        var eventArgs = new OperationEventArgs { OperationData = operationData };
                        CalculatingFinished?.Invoke(this, eventArgs);
                    }
                    catch (Exception e)
                    {                       
                        var wrongOperationData = new OperationData(choosenOperation.Name, null, numbers.number1, numbers.number2);
                        var eventErrorArgs = new OperationEventArgs { OperationData = wrongOperationData };
                        CalculatingError?.Invoke(this, eventErrorArgs);
                        _userComunication.ShowMessage(e.Message);
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                }           
            } while (true);        
        }
    }
}
