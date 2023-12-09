using Pagination.Infrastructure;
using Shouldly;

namespace Pagination.Tests.InfastructureTests;

public class InMemoryProductsListTests
{
    [Fact]
    public void inMemoryProductsList_GetProducts_method_should_return_100_products()
    {
        //Arrange
        InMemoryProductsList inMemoryProductsList = new();
        //Act
        var productList = inMemoryProductsList.GetProducts();
        //Assert
        productList.Count().ShouldBe(100);
    }
    
}