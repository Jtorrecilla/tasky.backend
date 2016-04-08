using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(tktTodoAppService.Startup))]

namespace tktTodoAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}