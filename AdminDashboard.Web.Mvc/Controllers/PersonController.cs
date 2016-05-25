using System.Web.Mvc;
using AdminDashboard.Service;
using AdminDashboard.Service.Interfaces;

namespace AdminDashboard.Web.Mvc.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetById(int id)
        {
            return Json(_personService.GetById(id), JsonRequestBehavior.AllowGet);
        }

    }
}