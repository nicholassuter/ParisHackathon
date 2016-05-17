using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Paris.Startup))]
namespace Paris
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //zreoij
        }
    }
}
