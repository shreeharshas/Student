using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DashBoardMVC.Startup))]
namespace DashBoardMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
