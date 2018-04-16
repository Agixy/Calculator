namespace Infrastructure
{
    public class OperationData : IOperationData
    {
        public string Name { get; }
        public int? Result { get; }
        public int InputNumber1 { get; }
        public int InputNumber2 { get; }

        public OperationData(string name, int? result, int inputNumber1, int inputNumber2)
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
            return $"Działanie: {Name}, Liczby: {InputNumber1}, {InputNumber2}, Wynik: {Result?.ToString() ?? "brak"}";
        }

        public string ToCSV()
        {
            return $"{Name},{InputNumber1},{InputNumber2},{Result}";
        }
    }
}
