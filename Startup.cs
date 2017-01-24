using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcLab1.Startup))]
namespace MvcLab1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
