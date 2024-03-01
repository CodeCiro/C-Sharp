using System.Web;
using System.Web.Mvc;

namespace Lab2_WebAppASPNetMVC_Basics
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
