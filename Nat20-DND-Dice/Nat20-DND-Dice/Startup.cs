using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nat20_DND_Dice.Startup))]
namespace Nat20_DND_Dice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
