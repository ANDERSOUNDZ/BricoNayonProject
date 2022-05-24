using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BricoNayonProject.Startup))]
namespace BricoNayonProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
