using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetMatcher.Startup))]
namespace PetMatcher
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
