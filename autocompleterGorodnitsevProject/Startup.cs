using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(autocompleterGorodnitsevProject.Startup))]
namespace autocompleterGorodnitsevProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
