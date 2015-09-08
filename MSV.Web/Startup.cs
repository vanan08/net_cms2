using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMC.MSV.Web.Startup))]
namespace CMC.MSV.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
