using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;

namespace StudentPortal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IRequestLogService _logService;

        public StudentsController(IRequestLogService logService)
        {
            _logService = logService;
        }

        public IActionResult Index()
        {
            var logs = _logService.GetLogs();
            return View(logs);
        }

        public IActionResult Details(int id)
        {
            ViewBag.Id = id;
            ViewBag.Name = "Priti";
            ViewBag.Age = 20;

            return View();
        }
    }
}