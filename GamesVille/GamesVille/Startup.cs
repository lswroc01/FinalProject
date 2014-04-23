using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamesVille.Startup))]
namespace GamesVille
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
