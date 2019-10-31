using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;

namespace MvcApiCall.Controllers
{
  public class PetsController : Controller
    {
        public IActionResult Index()
        {
            var allPets = Pet.GetPets();
            return View(allPets);
        }
    }
}