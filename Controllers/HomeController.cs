using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult NotFound()
        //{
        //    ViewData["Title"] = "404";
        //    return View();
        //}
        public IActionResult Blog()
        {
            ViewData["Title"] = "Блог";
            return View();
        }

        public IActionResult BlogSingle()
        {
            ViewData["Title"] = "Блог одиночный";
            return View();
        }

        public IActionResult Cart()
        {
            ViewData["Title"] = "Cart";
            return View();
        }

        public IActionResult Checkout()
        {
            ViewData["Title"] = "Checkout";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Title"] = "Контакты";
            return View();
        }

        public IActionResult Login()
        {
            ViewData["Title"] = "Вход";
            return View();
        }

        public IActionResult ProductDetails()
        {
            ViewData["Title"] = "Вход";
            return View();
        }

        public IActionResult Shop()
        {
            ViewData["Title"] = "Вход";
            return View();
        }

        //public IActionResult Shop()
        //{
        //    ViewData["Title"] = "Вход";
        //    return View();
        //}
    }
}