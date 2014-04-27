using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3whisky.web
{
    public static class MainKernel
    {
        public static IKernel Kernel
        {
            get;
            private set;
        }

        public static void Init()
        {
            var kernel = new StandardKernel();
            kernel.Load(AppDomain.CurrentDomain.GetAssemblies());

            Kernel = kernel;
        }
    }
}