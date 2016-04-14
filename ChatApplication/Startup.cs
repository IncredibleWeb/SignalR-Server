using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatApplication.Startup))]
namespace ChatApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            app.MapSignalR();
        }
    }
}
