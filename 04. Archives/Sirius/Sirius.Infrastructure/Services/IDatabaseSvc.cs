using Equistat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.Services
{
    public interface IDatabaseSvc
    {
        EquistatEntities DB { get; }
        void InitializeUserSettings();
    }
}
