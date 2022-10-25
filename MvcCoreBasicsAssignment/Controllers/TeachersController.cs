using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcCoreBasicsAssignment.Models;
using MvcCoreBasicsAssignment.Services;

namespace MvcCoreBasicsAssignment.Controllers
{
    public class TeachersController : Controller
    {


        private readonly ITeacherService _teacherService;


        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public IActionResult Index()
        {

            return View(_teacherService.GetTeachersList().ToList());
        }

        // GET: Teachers1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teachers1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                _teacherService.CreateTeachers(teacher);
                return RedirectToAction("Index");
            }
            return View(teacher);
        }
    }
}
