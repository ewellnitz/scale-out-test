using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ScaleOutTest
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Debug.WriteLine("WebApiApplication::Application_Start");
            WebApiConfig.Log.Add("WebApiApplication::Application_Start");
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
