using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces;

namespace Calculator
{
    public class UserComunication : IUserComunication
    {
        

        public string EnterName()
        {
            Console.WriteLine("Podaj swoje imie");
            var name = Console.ReadLine();
            return name;
        }

        public string ChooseOperation(List<string> operationsList)        // zrobić słownikiem na numerki?
        {

            Console.WriteLine("Wybierz operację");
            foreach (var operationName in operationsList)
            {
                Console.WriteLine($"{operationName}");
            }

            var operation = Console.ReadLine();

            Console.ReadKey();

            return operation;
        }
    }
}
