using Ninject.Modules;

using Whisky.Db;
using Whisky.Logic.Emails;
using Whisky.Logic.Orders;

namespace Whisky.Web
{
    public class WebNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbConfiguration>().To<DefaultDbConfiguration>();
            Bind<ISmtpConfiguration>().To<DefaultSmtpConfiguration>();
            Bind<IFeeConfiguration>().To<DefaultFeeConfiguration>();
        }
    }
}