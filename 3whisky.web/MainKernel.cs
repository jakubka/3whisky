using Ninject;

using Whisky.Db;
using Whisky.Logic;

namespace Whisky.Web
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

            kernel.Load(new DbNinjectModule());
            kernel.Load(new WebNinjectModule());
            kernel.Load(new LogicNinjectModule());

            Kernel = kernel;
        }
    }
}