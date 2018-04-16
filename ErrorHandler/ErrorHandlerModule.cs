using Infrastructure.Interfaces;
using Ninject.Modules;

namespace ErrorHandler
{
    public class ErrorHandlerModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IErrorHandler>().To<ErrorHandler>();
            Bind<IErrorHandlerUserComunication>().To<ErrorHandlerUserComunication>();
        }
    }
}
