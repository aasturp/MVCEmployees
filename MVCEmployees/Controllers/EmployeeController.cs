using Microsoft.AspNetCore.Mvc;
using MVCEmployees.Models;

namespace MVCEmployees.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeesService service;
        public EmployeeController()
        {
            service = new EmployeesService(); //nyas upp vid varje anrop. så varje gång får vi en ny lista och när dem fyller i listan sparas det inte.

        }

        [HttpGet("")]
        [HttpGet("index.html")]
        [HttpGet("index.php")]

        public IActionResult Index()
        {
            var model = service.GetAllEmployees(); 

            return View(model); 
        }

        [HttpGet("create")] 
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Employee employee) 
        {
            if (!ModelState.IsValid) 
            {
                return View();
            }
            service.Add(employee); 
            return RedirectToAction(nameof(Index)); 
        }
    }
}
