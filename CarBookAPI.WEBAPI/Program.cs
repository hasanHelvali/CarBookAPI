/*API projesinde Mþgration islemleri icin   Design paketinin olmasý gerekiyor. 
 Daha sonra bu proje uzerinde persistence katmanýný refere ediyoruz. Dolayýsýyla Domain katmaný da refere edilmis oluyor.*/

using CarBookAPI.Application.Features.CQRS.Commands.About.CreateAbout;
using CarBookAPI.Application.Features.CQRS.Commands.About.RemoveAbout;
using CarBookAPI.Application.Features.CQRS.Commands.About.UpdateAbout;
using CarBookAPI.Application.Features.CQRS.Commands.Banner.CreateBanner;
using CarBookAPI.Application.Features.CQRS.Commands.Banner.RemoveBanner;
using CarBookAPI.Application.Features.CQRS.Commands.Banner.UpdateBanner;
using CarBookAPI.Application.Features.CQRS.Commands.Brand.CreateBrandCommand;
using CarBookAPI.Application.Features.CQRS.Commands.Brand.RemoveBrandCommand;
using CarBookAPI.Application.Features.CQRS.Commands.Brand.UpdateBrandCommand;
using CarBookAPI.Application.Features.CQRS.Queries.About.GetAbout;
using CarBookAPI.Application.Features.CQRS.Queries.About.GetAboutById;
using CarBookAPI.Application.Features.CQRS.Queries.Banner.GetBanner;
using CarBookAPI.Application.Features.CQRS.Queries.Banner.GetBannerById;
using CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrand;
using CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrandById;
using CarBookAPI.Application.Interfaces;
using CarBookAPI.Persistence.Context;
using CarBookAPI.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<CarBookContext>();
//builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddScoped(CarBookAPI.Application.Interfaces.IRepository, CarBookAPI.Persistence.Repositories.Repository);
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();

builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
