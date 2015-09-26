using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkoutTacker.Startup))]
namespace WorkoutTacker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
