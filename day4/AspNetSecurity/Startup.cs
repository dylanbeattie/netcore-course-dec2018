using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetSecurity.Startup))]
namespace AspNetSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
