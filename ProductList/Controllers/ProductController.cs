using ProductList.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ProductList.Controllers
    {
    public class ProductController : Controller
        {
        public ActionResult Index()
            {
            var viewModel = new ProductViewModel
                {
                Categories = ProductRepository.GetCategories(),
                Products = ProductRepository.GetProducts(),
                Suppliers = ProductRepository.GetSuppliers()
            };
            return View(viewModel);
            }

        public ActionResult GetProductsByCategory(int categoryId)
        {
            var products = ProductRepository.GetProducts()
                .Where(p => p.CategoryId == categoryId)
                .Select(p => new { p.Id, p.Name })
                .ToList();

            return Json(products);
        }

        public ActionResult AddProduct(int productId, string productName)
            {
            // Here you can add the product to your data store or perform other actions
            return Content("OK", "text/plain");
            }

        public JsonResult GetCategoriesBySupplier(int supplierId)
        {
            var categories = ProductRepository.GetCategories()
                .Where(c => c.SupplierId == supplierId)
                .ToList();

            return Json(categories);
        }


    }
    }