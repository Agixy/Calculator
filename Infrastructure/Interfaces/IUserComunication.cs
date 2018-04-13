using System.Collections.Generic;

namespace Infrastructure.Interfaces
{
    public interface IUserComunication
    {      
        string ChooseOperation(List<string> operationsList);
        (int number1, int number2) EnterNumbers();
        void ShowResult(double result);
        void WrongDataMessage();
        void ShowMessage(string message);
    }
}