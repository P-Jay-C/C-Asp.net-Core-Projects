using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult  Index()
        {

            return View(dogs);
        }

        public IActionResult Create()
        {
            DogViewModel dogVm = new DogViewModel();

            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dog)
        {
            dogs.Add(dog);
            //return View("Index");
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "Who's there?";
        }

    }
}
