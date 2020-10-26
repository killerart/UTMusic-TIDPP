using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(UTMusic_TIDPP.OwinConfig))]
namespace UTMusic_TIDPP
{
    public class OwinConfig
    {
        public void Configuration(IAppBuilder app) {
        }
    }
}