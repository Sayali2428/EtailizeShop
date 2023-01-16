using ETailize_Shop.Api.Model;
using ETailize_Shop.Api.Services;

namespace ETailize_Shop.Api.Controllers
{
    public class ProductsController
    {
        public List<Product> Get()
        {
            var productService = new ProductService();
            return productService.GetProducts();
        }
    }
}
