using _3whisky.configuration;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3whisky.web
{
    public class WebNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbConfiguration>().To<WebConfigConfiguration>();
        }
    }
}