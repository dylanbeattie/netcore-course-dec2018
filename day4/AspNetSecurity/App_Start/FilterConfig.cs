using System.Web;
using System.Web.Mvc;

namespace AspNetSecurity {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
