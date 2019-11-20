using System.Web;
using System.Web.Mvc;

namespace Leder
{
    public class FilterConfig5
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
