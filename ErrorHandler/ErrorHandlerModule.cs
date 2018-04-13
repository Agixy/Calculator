using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace ErrorHandler
{
    public class ErrorHandlerModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IErrorHandler>().To<ErrorHandler>();
        }
    }
}
