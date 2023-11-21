using System.Web;
using System.Web.Mvc;

namespace Dự_án_quản_lý_quán_cafe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
