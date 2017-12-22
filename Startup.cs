using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment2084_2.Startup))]
namespace Assignment2084_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
