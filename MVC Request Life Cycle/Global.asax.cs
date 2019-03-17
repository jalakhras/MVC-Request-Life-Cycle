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
            Debug.WriteLine("Begin Request this Exeute when Begin Requst." +
                "Application_BeginRequest is an event handler.  It is part of the ASP.NET website system." +
                " The Application_BeginRequest method is executed on all requests handled by the ASP.NET runtime." +
                " Occurs as the first event in the HTTP pipeline chain of execution when ASP.NET responds to a request. The BeginRequest event signals the creation of any given new request." +
                "This event is always raised and is always the first event to occur during the processing of a request");


        }
        protected void Application_AuthenticateRequest()
        {
            Debug.WriteLine("Authenticate Request " +
                "The AuthenticateRequest event signals that the configured authentication mechanism has authenticated the current request." +
                "Subscribing to the AuthenticateRequest event ensures that the request will be authenticated before processing the attached module or event handle.");

        }
        protected void Application_AuthorizeRequest()
        {
            Debug.WriteLine("Authorize Request " +
                "The AuthorizeRequest event signals that ASP.NET has authorized the current request." +
                "You can subscribe to the AuthorizeRequest event to perform custom authorization.");

        }


        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("Map Handler this Exeute After End  Begin Requst to get map Requst" +
                "The MapRequestHandler event is used by the ASP.NET infrastructure to determine the request handler for the current request based on the file-name extension of the requested resource.");

        }

        protected void Application_PostMapRequestHandler()
        {
            Debug.WriteLine("Post Map Handler , Occurs when ASP.NET has mapped the current request to the appropriate HTTP handler");
        }

        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("Request State ," +
                "Occurs when ASP.NET acquires the current state (for example, session state) that is associated with the current request. A valid session ID must exist.");
        }

        protected void Application_PreRequestHandlerExecute()
        {
            Debug.WriteLine("Pre Handler Execute brfore  this compiler execute Action (Requset) ," +
                "Occurs just before ASP.NET starts executing an event handler.");
        }

        protected void Application_PostRequestHandlerExecute()
        {
            Debug.WriteLine("Post Handler Execute Note : this execute After execute Action Methods," +
                "Occurs when the ASP.NET event handler has finished generating the output ");
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
