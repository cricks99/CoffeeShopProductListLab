using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoffeeShopProductListLab.Models;

namespace CoffeeShopProductListLab.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository repo;

        public ProductController()
        {
            repo = new ProductRepository();
        }

        // GET: ProductController
        public ActionResult Index()
        {
            return View(repo.GetProducts());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View(repo.GetProducts().FirstOrDefault(x => x.Id == id));
        }

        public ActionResult Category(string id)
        {
            return View(repo.GetProducts().Where(x => x.Category == id));
        }
    }
}
