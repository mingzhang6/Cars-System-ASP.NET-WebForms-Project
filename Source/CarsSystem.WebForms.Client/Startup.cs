using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarsSystem.WebForms.Client.Startup))]
namespace CarsSystem.WebForms.Client
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
