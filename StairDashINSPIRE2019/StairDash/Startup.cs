using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StairDash.Startup))]
namespace StairDash
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
