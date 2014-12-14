using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColourDataRP.Controllers
{
    public class ReportController : Controller
    {
        //
        // GET: /Report/
        public ActionResult Index()
        {
            string viewName = ControllerContext.RouteData .GetRequiredString("action");
ViewEngineResult result = ViewEngines.Engines.FindView(ControllerContext, viewName, null);
if (null == result.View)
{
}
result.ViewEngine.ReleaseView(ControllerContext, result.View);

            return View();
        }

        public ActionResult ShowReport()
        {
            return View();
        }
	}
}