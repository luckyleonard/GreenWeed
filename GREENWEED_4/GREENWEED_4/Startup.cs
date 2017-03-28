using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GREENWEED_4.Startup))]
namespace GREENWEED_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
