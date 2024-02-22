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
using CarBookAPI.Application.Features.CQRS.Commands.Car.CreateCar;
using CarBookAPI.Application.Features.CQRS.Commands.Car.RemoveCar;
using CarBookAPI.Application.Features.CQRS.Commands.Car.UpdateCar;
using CarBookAPI.Application.Features.CQRS.Commands.Category.CreateCategory;
using CarBookAPI.Application.Features.CQRS.Commands.Category.RemoveCategory;
using CarBookAPI.Application.Features.CQRS.Commands.Category.UpdateCategory;
using CarBookAPI.Application.Features.CQRS.Commands.Contact.CreateContact;
using CarBookAPI.Application.Features.CQRS.Commands.Contact.RemoveContact;
using CarBookAPI.Application.Features.CQRS.Commands.Contact.UpdateContact;
using CarBookAPI.Application.Features.CQRS.Queries.About.GetAbout;
using CarBookAPI.Application.Features.CQRS.Queries.About.GetAboutById;
using CarBookAPI.Application.Features.CQRS.Queries.Banner.GetBanner;
using CarBookAPI.Application.Features.CQRS.Queries.Banner.GetBannerById;
using CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrand;
using CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrandById;
using CarBookAPI.Application.Features.CQRS.Queries.Car.GetCar;
using CarBookAPI.Application.Features.CQRS.Queries.Car.GetCarById;
using CarBookAPI.Application.Features.CQRS.Queries.Category.GetCategory;
using CarBookAPI.Application.Features.CQRS.Queries.Category.GetCategoryById;
using CarBookAPI.Application.Features.CQRS.Queries.Contact.GetContact;
using CarBookAPI.Application.Features.CQRS.Queries.Contact.GetContactById;
using CarBookAPI.Application.Features.CQRS.Queries.GetCarWithBrand;
using CarBookAPI.Application.Interfaces;
using CarBookAPI.Application.Interfaces.BlogInterfaces;
using CarBookAPI.Application.Interfaces.CarInterfaces;
using CarBookAPI.Application.Services;
using CarBookAPI.Persistence.Context;
using CarBookAPI.Persistence.Repositories;
using CarBookAPI.Persistence.Repositories.BlogRepositories;
using CarBookAPI.Persistence.Repositories.CarRepositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<CarBookContext>();
//builder.Services.AddSingleton<CarBookContext>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));

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

builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();

builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();

builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();

builder.Services.AddScoped<IBlogRepository,BlogRepository>();

builder.Services.AddCors(configuration =>configuration.AddDefaultPolicy(policiy=>
    policiy.WithOrigins("http://localhost:4200", "https://localhost:4200")
    .AllowAnyHeader().AllowAnyMethod().AllowCredentials()));

builder.Services.AddApplicationService(builder.Configuration);
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

app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
