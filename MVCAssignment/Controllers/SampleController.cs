using Microsoft.AspNetCore.Mvc;

namespace MVCAssignment.Controllers
{
    public class SampleController : Controller{
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Todolist(int id, string title, string description)
        {
            var todo = new {Id = id, Title = title, Description = description};
            ViewData["TodoItem"] = $"{todo.Title} ({todo.Id}): {todo.Description}";
            return View(todo);
        }
    }
}