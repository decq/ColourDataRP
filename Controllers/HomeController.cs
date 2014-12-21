using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColourDataRP.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "彩数（上海）商务咨询有限公司";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "联系方式";

            return View();
        }
    }
}