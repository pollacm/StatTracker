using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StatTracker.Startup))]
namespace StatTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
