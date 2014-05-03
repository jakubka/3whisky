using Ninject.Modules;

namespace Whisky.Db
{
    public class DbNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
