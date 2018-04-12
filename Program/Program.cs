using Calculator;
using HistoryLogger;
using Infrastructure;
using Infrastructure.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel container = new StandardKernel(new CalculatorModule(), new ProgramModule(), new HistoryLoggerModule());

            var flow = container.Get<ICalculatorFlow>();
            var operatrions = container.Get<ILogger>();

            flow.Run();         
           
        }
    }
}
