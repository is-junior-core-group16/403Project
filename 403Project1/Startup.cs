using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_403Project1.Startup))]
namespace _403Project1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
