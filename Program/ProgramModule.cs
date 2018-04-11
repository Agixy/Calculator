using Infrastructure;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class ProgramModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOperationData>().To<OperationData>();
        }
    }
}
