using System.Web;
using System.Web.Mvc;

namespace WebAPIConsuminginSameExercise
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
