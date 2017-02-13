using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalBestFitness_MVC.Startup))]
namespace PersonalBestFitness_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
