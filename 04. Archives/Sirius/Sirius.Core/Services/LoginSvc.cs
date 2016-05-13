using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equistat.Infrastructure.Services;
using Equistat.Infrastructure.BaseClasses;
using Microsoft.Practices.Unity;
using Equistat.Infrastructure.Attributes;
using Equistat.Resources.Properties;
using Equistat.Infrastructure.Events;
using Equistat.Infrastructure.UI.ViewModels;

namespace Sirius.Core.Services
{
    public class LoginSvc : ServiceBase, ILoginSvc
    {
        [Service]
        public IApp Application { get; set; }
        [Service]
        public IDatabaseSvc DatabaseSvc { get; set; }
        [Service]
        public IUIManagerSvc UIManagerSvc { get; set; }

        public LoginSvc(IUnityContainer container)
            : base(container)
        {
        }

        public string CurrentUsername
        {
            get
            {
                string result = Resources.Properties.Resources.NA_Text;
                var user = this.Application.USER;
                if (user != null)
                {
                    result = String.Format("{0} {1}", user.Surname, user.Name);
                }
                return result;
            }
        }

        public bool Validate(string username, string password)
        {
            var user = this.DatabaseSvc.DB.User.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (user != null)
            {
                this.Application.USER = user;

                this.EventAggregator.GetEvent<LoginEvent>().Publish(user.ID);
                return true;
            }
            return false;
        }

        public void Logout()
        {
            this.EventAggregator.GetEvent<LogoutEvent>().Publish(null);

            var dlg = this.UnityContainer.Resolve<ILoginViewModel>();
            this.UIManagerSvc.ShowDialog(dlg);
        }

        public bool CanUserAccess(string moduleName)
        {
            if (moduleName == Resources.Properties.Resources.Application_Text)
            {
                return (this.Application.USER.Right.Level == 0);
            }
            if (moduleName == Resources.Properties.Resources.Products_Text)
            {
                return (this.Application.USER.Right.Level == 0 || this.Application.USER.Right.Level == 1);
            }
            if (moduleName == Resources.Properties.Resources.Breaks_Text)
            {
                return (this.Application.USER.Right.Level == 0 || this.Application.USER.Right.Level == 1);
            }
            if (moduleName == Resources.Properties.Resources.Sensors_Text)
            {
                return (this.Application.USER.Right.Level == 0 || this.Application.USER.Right.Level == 1);
            }
            if (moduleName == Resources.Properties.Resources.Machines_Text)
            {
                return (this.Application.USER.Right.Level == 0 || this.Application.USER.Right.Level == 1) ;
            }
            if (moduleName == Resources.Properties.Resources.Scans_Text)
            {
                return (this.Application.USER.Right.Level == 0 || this.Application.USER.Right.Level == 1);
            }
            if (moduleName == Resources.Properties.Resources.Cycles_Text)
            {
                return (this.Application.USER.Right.Level == 0 || this.Application.USER.Right.Level == 1);
            }
            if (moduleName == Resources.Properties.Resources.TechSupport_Text)
            {
                return (this.Application.USER.Right.Level == 0 || this.Application.USER.Right.Level == 1);
            }
            if (moduleName == Resources.Properties.Resources.General_Text)
            {
                return (this.Application.USER.Right.Level == 0 || this.Application.USER.Right.Level == 1 || this.Application.USER.Right.Level == 2);
            }
            if (moduleName == Resources.Properties.Resources.Graphic_Text)
            {
                return (this.Application.USER.Right.Level == 0 || this.Application.USER.Right.Level == 1 || this.Application.USER.Right.Level == 2);
            }

            return true;
        }

        //public string GetMD5(string input)
        //{
        //    if (String.IsNullOrEmpty(input)) return String.Empty;

        //    MD5 md5 = MD5.Create();
        //    byte[] inputBytes = ASCIIEncoding.ASCII.GetBytes(input);
        //    byte[] hash = md5.ComputeHash(inputBytes);

        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < hash.Length; i++)
        //    {
        //        sb.Append(hash[i].ToString("X2"));
        //    }

        //    return sb.ToString();
        //}
    }
}
