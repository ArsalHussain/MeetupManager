using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeetupManager.Startup))]
namespace MeetupManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
