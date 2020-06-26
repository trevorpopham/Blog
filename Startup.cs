using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Falcon_Blog_2.Startup))]
namespace Falcon_Blog_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
