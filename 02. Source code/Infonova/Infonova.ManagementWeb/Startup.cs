using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Infonova.ManagementWeb.Startup))]
namespace Infonova.ManagementWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
