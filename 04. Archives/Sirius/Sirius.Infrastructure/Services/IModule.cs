using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace Equistat.Infrastructure.Services
{
    public interface IModule
    {
        void Register(IUnityContainer container);
    }
}
