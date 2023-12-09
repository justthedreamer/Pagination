using Pagination.Model;

namespace Pagination.Application.Repositories;

public interface IApplicationRepository
{
    RangeResponse GetRangeProductsListResponse(int range, int page);
}