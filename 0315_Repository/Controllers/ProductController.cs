using _0315_Repository.Models;
using _0315_Repository.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
            var PromotionList = MockData.productList.Where(x => x.IsPromotion == true);
            return View(PromotionList);
        }

        public IActionResult Detail(int id)
        {
            var Product = MockData.productList.FirstOrDefault(x => x.Id == id);
            return View(Product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var Product = MockData.productList.FirstOrDefault(x => x.Id == id);
            return View(Product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var EditProduct = MockData.productList.FirstOrDefault(x => x.Id == product.Id);

            EditProduct.Name = product.Name;
            EditProduct.Price = product.Price;
            EditProduct.IsPromotion = product.IsPromotion;

            return RedirectToAction(nameof(Index));
        }
    }
}
