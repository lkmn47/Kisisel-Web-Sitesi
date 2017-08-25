using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MuratDogan.MVCWebUI.Startup))]
namespace MuratDogan.MVCWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
