using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GreenTrackerBoo.Startup))]
namespace GreenTrackerBoo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
