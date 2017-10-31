using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Int_Pagina.Startup))]
namespace Int_Pagina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
