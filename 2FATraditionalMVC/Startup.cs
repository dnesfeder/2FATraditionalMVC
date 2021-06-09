using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2FATraditionalMVC.Startup))]
namespace _2FATraditionalMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
