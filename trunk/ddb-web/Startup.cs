using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ddb_web.Startup))]
namespace ddb_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
