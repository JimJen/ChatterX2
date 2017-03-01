using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatterX2.Startup))]
namespace ChatterX2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
