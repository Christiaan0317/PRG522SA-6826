using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRG522SA_6826.Startup))]
namespace PRG522SA_6826
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
