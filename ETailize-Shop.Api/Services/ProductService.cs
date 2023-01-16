using ETailize_Shop.Api.Model;

namespace ETailize_Shop.Api.Services
{
    public class ProductService
    {
        public ProductService()
        {
            
        }

        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Bicycle",
                    Description = "Nice Bicycle",
                    Price = 56.5M
                },
                new Product()
                {
                    Id = 2,
                    Name = "Bicycle",
                    Description = "Nice Bicycle",
                    Price = 56.5M
                },
                new Product()
                {
                    Id = 3,
                    Name = "Head Set",
                    Description = "Nice Bicycle",
                    Price = 56.5M
                },
                new Product()
                {
                    Id = 4,
                    Name = "Laptop",
                    Description = "Nice Bicycle",
                    Price = 56.5M
                },
                new Product()
                {
                    Id = 5,
                    Name = "IPhone",
                    Description = "Nice Bicycle",
                    Price = 56.5M
                },
            };
        }
    }
}
