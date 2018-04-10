using System.Collections.Generic;

namespace Infrastructure.Interfaces
{
    public interface IOperationProvider
    {
        string[] GetOperationsName();
        IOperation this[string n] { get; }
    }
}