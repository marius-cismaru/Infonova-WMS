using Equistat.Data;
using Equistat.Infrastructure.Attributes;
using Equistat.Infrastructure.BaseClasses;
using Equistat.Infrastructure.Services;
using Equistat.Resources.Properties;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Globalization;
using System.Threading;

namespace Sirius.Core.Services
{
    public class DatabaseSvc : ServiceBase, IDatabaseSvc
    {
        public EquistatEntities DB { get; private set; }

        [Service]
        public IUIManagerSvc UIManagerSvc { get; set; }

        public DatabaseSvc(IUnityContainer container)
            : base(container)
        {
            this.DB = new EquistatEntities();
        }

        public void InitializeUserSettings()
        {
            var defaultSettings = this.DB.Settings.FirstOrDefault();
            var userSettings = this.DB.UserSettings.FirstOrDefault(i => i.IDUser == this.App.USER.ID);

            if (userSettings == null)
            {
                this.DB.UserSettings.AddObject(new UserSettings()
                {
                    RealTimeDisplayMinutes = defaultSettings.RealTimeDisplayMinutes,
                    RefreshSensorsSeconds = defaultSettings.RefreshSensorsSeconds,
                    IDUser = this.App.USER.ID,
                });
                this.DB.SaveChanges();
            }
        }
    }
}