using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces;

namespace Calculator
{
    internal class UserComunication : IUserComunication
    {
        public string ChooseOperation(List<string> operationsList) 
        {
            Console.WriteLine("Wybierz operację");
            foreach (var operationName in operationsList)
            {
                Console.WriteLine($" {operationName}");
            }

            var choosenOperationName = Console.ReadLine();
            return choosenOperationName;
        }
     
        public (int number1, int number2) EnterNumbers()
        {
            bool correctNumber = true;
            var numbers = (0, 0);
            do
            {
                try
                {
                    Console.WriteLine("Podaj pierwszą liczbe:");
                    int number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj drugą liczbę:");
                    int number2 = int.Parse(Console.ReadLine());
                    numbers = (number1, number2);
                    correctNumber = true;
                }
                catch(Exception e)
                {
                    WrongDataMessage();
                    correctNumber = false;
                }                         
            } while (!correctNumber);

            return numbers;
        }

        public void ShowResult(double result)
        {
            Console.WriteLine($"Wynik: {result}");
        }

        public void WrongDataMessage()
        {
            Console.WriteLine("Nieprawidłowo wpisane dane");
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }       
    }
}
