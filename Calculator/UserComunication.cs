using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class UserComunication : IUserComunication
    {
        private readonly IOperationProvider _operationProvider;

        public string EnterName()
        {
            Console.WriteLine("Podaj swoje imie");
            var name = Console.ReadLine();
            return name;
        }

        public void ChooseOperation()
        {
            Console.WriteLine("Wybierz operację");
            foreach (var operationName in _operationProvider.GetOperationName())
            {

            }


        }
    }
}
