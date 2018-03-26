using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01_WhatIsLinq.Startup))]
namespace _01_WhatIsLinq
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
