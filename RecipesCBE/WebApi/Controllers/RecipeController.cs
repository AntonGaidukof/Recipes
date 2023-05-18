using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
