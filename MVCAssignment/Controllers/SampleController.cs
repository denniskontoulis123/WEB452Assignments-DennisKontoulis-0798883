using Microsoft.AspNetCore.Mvc;
using MVCAssignment.Models;

namespace MVCAssignment.Controllers{
    public class SampleController : Controller {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Todolist(int id, string title, string description)
        {
            var todo = new TodoItem { Id = id, Title = title, Description = description };
            return View(todo);
        }
    }
}