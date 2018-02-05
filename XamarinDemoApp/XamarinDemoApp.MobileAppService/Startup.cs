using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(XamarinDemoApp.MobileAppService.Startup))]

namespace XamarinDemoApp.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}