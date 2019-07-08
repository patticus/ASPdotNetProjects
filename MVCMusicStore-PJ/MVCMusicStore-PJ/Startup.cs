using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMusicStore_PJ.Startup))]
namespace MVCMusicStore_PJ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
