using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Leder.Startup))]
namespace Leder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
