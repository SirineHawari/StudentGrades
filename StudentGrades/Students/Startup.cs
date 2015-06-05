using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Students.Startup))]
namespace Students
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
