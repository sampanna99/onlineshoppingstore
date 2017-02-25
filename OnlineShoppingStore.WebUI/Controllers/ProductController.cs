using OnlineShoppingStore.Domain.Abstract;
using System.Linq;
using System.Web.Mvc;

namespace OnlineShoppingStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public int PageSize = 4;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        // GET: Product
        public ViewResult List(int page = 1)
        {
            return View(repository.Products
                .OrderBy(p => p.ProductId).Skip((page - 1) * PageSize).Take(PageSize)
                );
        }
    }
}