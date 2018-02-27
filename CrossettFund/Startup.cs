using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crosset.Startup))]
namespace crosset
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          
        }
    }
}
