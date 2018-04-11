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
        private readonly IUserComunication _userComunication;

        public CalculatorFlow(IOperationManager operationManager, IUserComunication userComunication)
        {
            _operationManager = operationManager;
            _userComunication = userComunication;
        }

        //public event EventHandler<wyniki> CalculatingFinished;

        public void Run()
        {
            Console.Clear();

            var name = _userComunication.EnterName();

            List<string> operationsList = new List<string>();       // wydzielic jakoś do interfejsu IOperation?
           
            foreach (var operationName in _operationManager.GetOperationsName())
            {
                operationsList.Add(operationName);
            }

            do
            { 

                var choosenOperation = _operationManager[_userComunication.ChooseOperation(operationsList)];

            
                if (choosenOperation == null)
                {
                    _userComunication.WrongDataMessage();
                }
                else
                {
                    Func<int, int, double> operation = choosenOperation.Calculate;

                    var numbers = _userComunication.EnterNumbers();

                    int number1 = numbers.number1;
                    int number2 = numbers.number2;

                    // Czemu nie da się tak: int result = operation(userComunication.EnterNumbers());  ??????????????

                    double result = operation(number1, number2);

                    _userComunication.ShowResult(result);

                    Console.ReadLine();
                }
            } while (true);

        }
    }
}
