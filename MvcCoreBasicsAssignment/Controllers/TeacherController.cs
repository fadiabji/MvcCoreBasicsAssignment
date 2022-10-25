using Microsoft.AspNetCore.Mvc;

namespace MvcCoreBasicsAssignment.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
