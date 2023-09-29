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
    }
}
