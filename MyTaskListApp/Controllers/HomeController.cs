using Microsoft.AspNetCore.Mvc;
using MyTaskListApp.Models;
using MyTaskListApp.Services;
using System.Threading.Tasks;

namespace MyTaskListApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskService _taskService;

        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _taskService.GetAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Create(TaskModel task)
        {
            try
            {
                await _taskService.CreateAsync(task);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
