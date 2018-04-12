﻿using Calculator.Operations;
using HistoryLogger;
using Infrastructure.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICalculatorFlow>().To<CalculatorFlow>().InSingletonScope();
            Bind<IUserComunication>().To<UserComunication>();
            Bind<IOperationManager>().To<OperationManager>();
            Bind<IOperation>().To<Add>();
            Bind<IOperation>().To<Substract>();
            Bind<IOperation>().To<Multiply>();
            Bind<IOperation>().To<Divide>();
            Bind<IOperation>().To<Power>();
            Bind<IOperation>().To<AND>();
            Bind<IOperation>().To<OR>();
            Bind<IOperation>().To<XOR>();
        }
    }
}
