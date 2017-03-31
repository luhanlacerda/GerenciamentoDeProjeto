using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicacaoWeb.Startup))]
namespace AplicacaoWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
