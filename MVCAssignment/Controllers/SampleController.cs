using Microsoft.AspNetCore.Mvc;

namespace MVCAssignment.Controllers
{
    public class SampleController : Controllers{
        public IActionResult Index()
        {
            return View();
        }
    }
}