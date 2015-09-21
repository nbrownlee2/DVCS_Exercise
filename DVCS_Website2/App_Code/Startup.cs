using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DVCS_Website2.Startup))]
namespace DVCS_Website2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
