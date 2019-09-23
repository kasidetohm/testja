using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testgithub.Startup))]
namespace testgithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
