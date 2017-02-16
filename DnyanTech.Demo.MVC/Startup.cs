using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DnyanTech.Demo.MVC.Startup))]
namespace DnyanTech.Demo.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
