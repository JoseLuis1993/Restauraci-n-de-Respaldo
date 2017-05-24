using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoRespaldo.Startup))]
namespace ProyectoRespaldo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
