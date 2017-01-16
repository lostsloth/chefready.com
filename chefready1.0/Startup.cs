using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(chefready1._0.Startup))]
namespace chefready1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
