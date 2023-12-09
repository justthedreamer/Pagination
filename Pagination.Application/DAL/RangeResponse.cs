using Pagination.Domain;

namespace Pagination.Model;

public class RangeResponse
{
    public IEnumerable<Product> Products { get; set; }
    public int TotalSites { get; set; }
}