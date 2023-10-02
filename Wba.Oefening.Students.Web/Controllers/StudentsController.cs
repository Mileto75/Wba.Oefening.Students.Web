using MessagePack;
using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Students.Core.Repositories;
using Wba.Oefening.Students.Web.ViewModels;

namespace Wba.Oefening.Students.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentRepository _studentRepository;

        public StudentsController()
        {
            _studentRepository = new StudentRepository();
        }
        public IActionResult Index()
        {
            ViewBag.Welcome = "Welcome to our student admin site!";
            return View();
        }
        public IActionResult ShowAll()
        {
            //get the students
            //init model
            //fill the model
            //pass to the view
            var studentsIndexViewModel = new StudentsIndexViewModel
            {
                Students = _studentRepository
                .GetAll()
                .OrderBy(s => s.Lastname)
                .Select(s => new BaseViewModel
                {
                    Id = s.Id,
                    Text = $"{s.Firstname} {s.Lastname}"
                })
            };
            return View(studentsIndexViewModel);
        }
        public IActionResult Details(int id)
        {
            //get the student
            var student = _studentRepository
                .GetAll()
                .FirstOrDefault(s => s.Id == id);
            //check if exists
            if(student == null) 
            {
                return NotFound();
            }
            //fill the model
            var studentsdetailsViewModel =
                new StudentsDetailsViewModel
                {
                    Id = student.Id,
                    Text = $"{student.Firstname} {student.Lastname}",
                    Course = student.Course,
                };
            //pass tot the view
            return View(studentsdetailsViewModel);
        }
    }
}
