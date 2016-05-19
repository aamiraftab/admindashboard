using System.Web.Mvc;
using AdminDashboard.Service;

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
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public JsonResult Index(int id)
        {
            return Json(_personService.GetById(id), JsonRequestBehavior.AllowGet);
        }

    }
}