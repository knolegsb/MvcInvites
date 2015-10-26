using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcInvites.Startup))]
namespace MvcInvites
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
