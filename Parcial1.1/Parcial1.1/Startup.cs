using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Parcial1._1.Startup))]
namespace Parcial1._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
