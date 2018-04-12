using Infrastructure.Interfaces;
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
            Bind<ILogger>().To<Logger>();
            Bind<IHistoryUserComunication>().To<HistoryUserComunication>();
            Bind<ISaving>().To<Saving>();
        }
    }
}
