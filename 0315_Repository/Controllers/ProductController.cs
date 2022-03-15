using _0315_Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace _0315_Repository.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var productList = MockData.productList;
            return View(productList);
        }

        public IActionResult Promotion()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
