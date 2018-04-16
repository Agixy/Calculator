using Infrastructure.Interfaces;
using Ninject.Modules;

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
