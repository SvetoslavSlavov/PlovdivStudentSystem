using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlovdivUniversity.Startup))]
namespace PlovdivUniversity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
