using System.Web.Mvc;

namespace ChristmasTrees.Controllers
{
    public class RoutesDemoController : Controller
    {
        // GET: RoutesDemo
        public ActionResult One()
        {
            return View();
        }

        public ActionResult Two(int donuts = 1)
        {
            ViewBag.Donuts = donuts;
            return View();
        }

        [Authorize]
        public ActionResult Three()
        {
            return View();
        }
    }
}