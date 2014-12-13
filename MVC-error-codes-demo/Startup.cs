using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_error_codes_demo.Startup))]
namespace MVC_error_codes_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
