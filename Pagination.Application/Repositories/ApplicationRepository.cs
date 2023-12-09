using Pagination.Infrastructure.Interfaces;
using Pagination.Model;

namespace Pagination.Application.Repositories;

public class ApplicationRepository : IApplicationRepository
{
    private readonly IInMemoryProductsListRepository _inMemoryProductsListRepository;

    public ApplicationRepository(IInMemoryProductsListRepository inMemoryProductsListRepository)
    {
        _inMemoryProductsListRepository = inMemoryProductsListRepository;
    }

    
    public RangeResponse GetRangeProductsListResponse(int range,int page)
    {
        var allProductsCount = _inMemoryProductsListRepository.GetProductsList().Count();

        var totalSites = (int)Math.Ceiling((double)allProductsCount / range);

        var products = _inMemoryProductsListRepository.GetRangeOfProducts(range, page);


        var response = new RangeResponse()
        {
            Products = products,
            TotalSites = totalSites
        };
        
        return response;
    }
}