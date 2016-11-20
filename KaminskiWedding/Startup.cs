using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KaminskiWedding.Startup))]
namespace KaminskiWedding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
