using CustomerManagement.Web.Angular;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace CustomerManagement.Web.Angular
{
    public partial class Startup
    {



        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
