using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DEVops.Startup))]
namespace DEVops
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
