using Microsoft.AspNetCore.Mvc;
using Pagination.Application;
using Pagination.Application.Repositories;
using Pagination.Infrastructure;
using Pagination.Infrastructure.Interfaces;
using Pagination.Model;

namespace Pagination.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
    private readonly IInMemoryProductsListRepository _repository;
    private readonly IApplicationRepository _applicationRepository;

    public HomeController(IInMemoryProductsListRepository repository, IApplicationRepository applicationRepository)
    {
        _repository = repository;
        _applicationRepository = applicationRepository;
    }
    
    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_repository.GetProductsList());
    }

    [HttpPost("getRange")]
    public ActionResult GetRangeOfProducts([FromBody] RangeRequest rangeRequest)
    {
        var response = _applicationRepository.GetRangeProductsListResponse(rangeRequest.Range, rangeRequest.Page);
        
        return Ok(response);
    }

}