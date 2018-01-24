using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(appweb1.Startup))]
namespace appweb1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
