using MVC_Request_Life_Cycle;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

[assembly: PreApplicationStartMethod(typeof(MvcApplication), "Register")]
namespace MVC_Request_Life_Cycle
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void Register()
        {
            HttpApplication.RegisterModule(typeof(LogModule));
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_BeginRequest()
        {
            Debug.WriteLine("Begin Request this Exeute when Begin Requst");
        }

        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("Map Handler this Exeute After End  Begin Requst to get map Requst");
        }

        protected void Application_PostMapRequestHandler()
        {
            Debug.WriteLine("Post Map Handler");
        }

        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("Request State");
        }

        protected void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("Pre Handler Execute After this compiler execute Action (Requset)");
        }

        protected void Application_PostRequestHandlerExecute()
        {
            Debug.WriteLine("Post Handler Execute Note : this execute After execute Action Methods ");
        }

        protected void Application_EndRequest()
        {
            Debug.WriteLine("End Request this execute After exeute PreApplicationStartMethod ");
        }


        protected void Application_End()
        {
            Debug.WriteLine("End");
        }
    }
}
