using Pagination.Application;
using Pagination.Application.Repositories;
using Pagination.Infrastructure;
using Pagination.Infrastructure.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IInMemoryProductsListRepository,InMemoryProductsListRepository>();
builder.Services.AddScoped<IApplicationRepository,ApplicationRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://127.0.0.1:5500")
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});

var app = builder.Build();

app.UseCors("AllowSpecificOrigin");
app.MapControllers();

app.Run();
