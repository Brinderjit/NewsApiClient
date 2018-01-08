using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsApiClient.Startup))]
namespace NewsApiClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
