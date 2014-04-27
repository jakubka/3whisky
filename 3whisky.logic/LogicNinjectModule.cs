using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3whisky.logic
{
    public class LogicNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderProcessor>().To<OrderProcessor>();
            Bind<IEmailSender>().To<EmailSender>();
        }
    }
}
