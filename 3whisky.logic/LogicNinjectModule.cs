using Ninject.Modules;

using Whisky.Logic.Emails;
using Whisky.Logic.Orders;

namespace Whisky.Logic
{
    public class LogicNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderProcessor>().To<OrderProcessor>();
            Bind<IEmailSender>().To<SmtpEmailSender>();
            Bind<IEmailGenerator>().To<HardcodedStringsEmailGenerator>();
            Bind<IShipmentDateCalculator>().To<HardcodedShipmentDateCalculator>();
            Bind<ITotalPriceCalculator>().To<TotalPriceCalculator>();
        }
    }
}
