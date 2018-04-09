using Calculator;
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

        public CalculatorFlow()
        {
        }



        internal void Run()
        {
            Console.Clear();

            var userComunication = new UserComunication();
            var name = userComunication.EnterName();

            userComunication.ChooseOperation();



        }
    }
}
