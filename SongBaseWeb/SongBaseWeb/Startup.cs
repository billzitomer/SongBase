using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SongBaseWeb.Startup))]
namespace SongBaseWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
