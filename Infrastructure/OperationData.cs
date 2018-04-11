using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class OperationData : IOperationData
    {
        public string Name { get; }

        public double Result { get; }

        public int[] InputNumbers { get; }

        public OperationData(string name, double result, int[] inputNumbers)
        {
            Name = name;
            Result = result;
            InputNumbers = inputNumbers;
        }

        public OperationData()
        {

        }

        public override string ToString()
        {
            return $"Działanie: {Name}, Liczby: {InputNumbers[0]}, {InputNumbers[1]}, Wynik: {Result}";
        }

        // publicDateTime OperationDate;
    }
}
