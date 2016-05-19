using System.Web.Mvc;

namespace AdminDashboard.Web.Mvc.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public ActionResult Index()
        {
            return View();
        }
    }
}