using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bailam.Startup))]
namespace bailam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
