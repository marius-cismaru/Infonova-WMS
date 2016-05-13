using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Infonova.ManagementWeb2.Startup))]
namespace Infonova.ManagementWeb2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
