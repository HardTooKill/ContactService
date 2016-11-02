using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeAssessment.Startup))]
namespace CodeAssessment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
