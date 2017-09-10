using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shooter.Startup))]
namespace Shooter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
