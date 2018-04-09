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
            IKernel container = new StandardKernel();

            container.Bind<ICalculatorFlow>().To<CalculatorFlow>();


            var flow = container.Get<CalculatorFlow>();

            flow.Run();
        }
    }
}
