using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equistat.Infrastructure.Services
{
    public interface ILoginSvc
    {
        string CurrentUsername { get; }
        //string GetMD5(string input);
        bool CanUserAccess(string moduleName);
        bool Validate(string username, string password);
        void Logout();
    }
}
