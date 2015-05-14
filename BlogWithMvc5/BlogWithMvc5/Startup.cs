using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogWithMvc5.Startup))]
namespace BlogWithMvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
