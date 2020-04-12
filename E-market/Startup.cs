using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_market.Startup))]
namespace E_market
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
