using Infrastructure;
using Ninject.Modules;

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
