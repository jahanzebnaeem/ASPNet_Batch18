using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCControl.Startup))]
namespace MVCControl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
