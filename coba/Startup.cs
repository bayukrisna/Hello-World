using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(coba.Startup))]
namespace coba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
