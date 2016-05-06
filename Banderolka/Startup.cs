using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Banderolka.Startup))]
namespace Banderolka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
