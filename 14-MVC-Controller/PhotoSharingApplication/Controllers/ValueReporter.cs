using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace PhotoSharingApplication.Controllers
{
    public class ValueReporter: ActionFilterAttribute
    {
        private void logValues(RouteData routeData)
        {
            var controller = routeData.Values["controller"];
            var action = routeData.Values["action"];
            string message = string.Format($"Controller: {controller}; Action: {action}");
            Debug.WriteLine("Action Values");
            foreach (var value in routeData.Values)
            {
                Debug.WriteLine($"Key: { value.Key }; Value: { value.Value }");
            }
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            logValues(filterContext.RouteData);
        }
    }
}