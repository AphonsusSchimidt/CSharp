using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataReaderMVC.Startup))]
namespace DataReaderMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
