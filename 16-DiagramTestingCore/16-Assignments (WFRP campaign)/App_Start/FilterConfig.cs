using System.Web;
using System.Web.Mvc;

namespace _16_Assignments__WFRP_campaign_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
