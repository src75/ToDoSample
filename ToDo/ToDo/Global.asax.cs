using System;
using FubuMVC.Core;
using FubuMVC.StructureMap;
using StructureMap;

namespace ToDo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            FubuApplication.For<ConfigureFubuMVC>().StructureMap(new Container()).Bootstrap();
        }
    }
}