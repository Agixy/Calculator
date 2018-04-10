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
                Console.WriteLine($" {operationName}");
            }

            var choosenOperationName = Console.ReadLine();

            return choosenOperationName;
        }

        public int EnterNumber(int numberOfNumber) // nazwa.????
        {
            Console.WriteLine($"Podaj {numberOfNumber} liczbę");
            int number = int.Parse(Console.ReadLine());
            return number;         
        }

        public (int number1, int number2) EnterNumbers()
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            int number2 = int.Parse(Console.ReadLine());

            var numbers = (number1, number2);

            return numbers;

        }

        public void ShowResult(int result)
        {
            Console.WriteLine($"Wynik: {result}");
        }
        

    }
}
