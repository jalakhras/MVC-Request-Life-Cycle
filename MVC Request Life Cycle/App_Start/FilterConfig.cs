using System.Web;
using System.Web.Mvc;

namespace MVC_Request_Life_Cycle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
