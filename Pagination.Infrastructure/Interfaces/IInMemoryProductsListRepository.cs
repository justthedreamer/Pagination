using Pagination.Domain;

namespace Pagination.Infrastructure.Interfaces;

public interface IInMemoryProductsListRepository
{
    IEnumerable<Product> GetProductsList();
    IEnumerable<Product> GetRangeOfProducts(int range, int page);
}