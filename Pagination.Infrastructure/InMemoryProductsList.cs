using System.Drawing;
using Pagination.Domain;

namespace Pagination.Infrastructure;

public class InMemoryProductsList
{
    private List<Product> Products = new();
    
    public InMemoryProductsList()
    {
        SeedProducts();
    }

    public IEnumerable<Product> GetProducts() => Products;
    private void SeedProducts()
    {
        for (int i = 1; i < 101; i++)
        {
            var productDescription = i % 2 == 0 ? "awesome" : "really bad.";
            
            Products.Add(new Product()
            {
                Id = i,
                Name = $"Product-{i}",
                Count = new Random().Next(1,101),
                Description = $"This product is {productDescription}"
                
            });
        }
    }
}
