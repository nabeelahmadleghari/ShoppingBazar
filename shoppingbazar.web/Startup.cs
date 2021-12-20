using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(shoppingbazar.web.Startup))]
namespace shoppingbazar.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
