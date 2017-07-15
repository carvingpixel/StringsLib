using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StringsWeb.Startup))]
namespace StringsWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
