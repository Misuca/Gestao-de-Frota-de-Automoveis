using System.Web;
using System.Web.Mvc;

namespace Gestão_de_Frota_de_Automóveis
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
