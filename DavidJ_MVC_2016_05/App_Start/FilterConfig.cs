using System.Web;
using System.Web.Mvc;

namespace DavidJ_MVC_2016_05
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
