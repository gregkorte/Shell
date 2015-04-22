using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChristmasTrees.Startup))]
namespace ChristmasTrees
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
