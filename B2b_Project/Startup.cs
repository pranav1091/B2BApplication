using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(B2b_Project.Startup))]
namespace B2b_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
