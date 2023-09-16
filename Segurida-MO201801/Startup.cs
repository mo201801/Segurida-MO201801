using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Segurida_MO201801.Startup))]
namespace Segurida_MO201801
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
