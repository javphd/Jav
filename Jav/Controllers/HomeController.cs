using Jav.Models;
using System.Web.Mvc;

namespace Jav.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "VASE Adaptive Authoring System";

            return View();
        }

        [HttpPost]
        public string Post(TestModel[] data)
        {
            var val = data[0];

            return val.ID + ": " + val.Value;
        }
    }
}
