using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JSDemos.Startup))]
namespace JSDemos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
