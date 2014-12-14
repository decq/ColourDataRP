using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ColourDataRP.Startup))]
namespace ColourDataRP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
