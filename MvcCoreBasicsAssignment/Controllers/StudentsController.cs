using Microsoft.AspNetCore.Mvc;
using MvcCoreBasicsAssignment.Services;
using MvcCoreBasicsAssignment.Models;
using MvcCoreBasicsAssignment.Data;
using System;

namespace MvcCoreBasicsAssignment.Controllers
{
    public class StudentsController : Controller
    {

        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // I can inject multiple services in the controller by passing them throgh the constracture like this ex:

        //private readonly IexampleService _exampleService;
        //public StudentController(IStudentService studentService, IexampleService exampleService)
        //{
        //    _exampleService = exampleService;
        //    _studentService = studentService;
        //}

        public IActionResult Index()
        {
            var studlist = _studentService.GetStudentSList();
            return View(studlist);
        }

        public IActionResult CreateListOfStudnet()
        {
            _studentService.CreateStudents();
            return RedirectToAction("Index");
        }
    }
}
