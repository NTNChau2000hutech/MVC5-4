using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bigschool_lap543.Startup))]
namespace bigschool_lap543
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
