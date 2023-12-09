using Pagination.Domain;
using Pagination.Infrastructure;
using Pagination.Infrastructure.Interfaces;

namespace Pagination.Application;

public sealed class InMemoryProductsListRepository : IInMemoryProductsListRepository
{
    private readonly InMemoryProductsList _productsList = new();

    public IEnumerable<Product> GetProductsList()
    {
        return _productsList.GetProducts();
    }

    public IEnumerable<Product> GetRangeOfProducts(int range, int page)
    {
        var totalProductsCount = _productsList.GetProducts().Count();
        var from = (( range * page ) + 1 ) - range ;
        var to = (page * range);
        
        var rageOfProducts = _productsList.GetProducts().Where(x => x.Id >= from && x.Id <= to);
        
        return rageOfProducts;
    }
}
