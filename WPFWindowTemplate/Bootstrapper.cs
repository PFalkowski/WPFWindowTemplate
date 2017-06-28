using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace WPFWindowTemplate
{
    public static class Bootstrapper
    {
        public static IUnityContainer Bootstrap(this IUnityContainer container)
        {
            container.RegisterType<IViewModel, ViewModel>(new ContainerControlledLifetimeManager());
            return container;
        }
    }
}
