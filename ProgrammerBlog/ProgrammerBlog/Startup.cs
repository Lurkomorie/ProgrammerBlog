using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProgrammerBlog.Startup))]
namespace ProgrammerBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
