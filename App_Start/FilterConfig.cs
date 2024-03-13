using System.Web;
using System.Web.Mvc;

namespace TilausDBAdvancedMVCPalautus
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
