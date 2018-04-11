using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryLogger
{
    public class HistoryLoggerModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<Logger>().WithConstructorArgument("howMany", 5);
        }
    }
}
