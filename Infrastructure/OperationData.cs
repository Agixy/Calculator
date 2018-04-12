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
        public int InputNumber1 { get; }
        public int InputNumber2 { get; }

        public OperationData(string name, double result, int inputNumber1, int inputNumber2)
        {
            Name = name;
            Result = result;
            InputNumber1 = inputNumber1;
            InputNumber2 = inputNumber2;
        }

        public OperationData()
        {
        }

        public override string ToString()
        {
            return $"Działanie: {Name}, Liczby: {InputNumber1}, {InputNumber2}, Wynik: {Result}";
        }

        public string ToCSV()
        {
            return $"{Name},{InputNumber1},{InputNumber2},{Result}";
        }

        // publicDateTime OperationDate;
    }
}
