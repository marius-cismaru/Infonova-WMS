using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Infrastructure.Services;
using Microsoft.Practices.Unity;
using Sirius.Core.Services;

namespace Sirius.Core
{
    public class CoreModule : IModule
    {
        public void Register(IUnityContainer container)
        {
            container.RegisterType<IUIManagerSvc, UIManagerSvc>(new ContainerControlledLifetimeManager());
            container.RegisterType<IDatabaseSvc, DatabaseSvc>(new ContainerControlledLifetimeManager());
            container.RegisterType<ILoginSvc, LoginSvc>(new ContainerControlledLifetimeManager());
            container.RegisterType<IExportSvc, ExportSvc>();
        }
    }
}