using System;

namespace Infrastructure
{
    public class OperationEventArgs : EventArgs
    {
        public OperationData OperationData { get; set; }
    }
}