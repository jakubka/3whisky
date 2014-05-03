using Ninject.Modules;

using Whisky.Db;
using Whisky.Logic.Emails;

namespace Whisky.Web
{
    public class WebNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbConfiguration>().To<DefaultDbConfiguration>();
            Bind<ISmtpConfiguration>().To<DefaultSmtpConfiguration>();
        }
    }
}