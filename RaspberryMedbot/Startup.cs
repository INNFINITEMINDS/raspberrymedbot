using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaspberryMedbot.Startup))]
namespace RaspberryMedbot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
