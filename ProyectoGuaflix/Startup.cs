using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoGuaflix.Startup))]
namespace ProyectoGuaflix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
