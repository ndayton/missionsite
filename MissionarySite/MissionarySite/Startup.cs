using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MissionarySite.Startup))]
namespace MissionarySite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
