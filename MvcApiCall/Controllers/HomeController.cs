using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;

namespace MvcApiCall.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allPets = Pet.GetPets();
            return View(allPets);
        }
    }
}