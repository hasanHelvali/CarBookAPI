
using CarBookAPI.Application.Features.CQRS.Commands.Brand.CreateBrandCommand;
using CarBookAPI.Application.Features.CQRS.Commands.Brand.RemoveBrandCommand;
using CarBookAPI.Application.Features.CQRS.Commands.Brand.UpdateBrandCommand;
using CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrand;
using CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrandById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;
        private readonly RemoveBrandCommandHandler _removeBrandCommandHandler;

        public BrandController(GetBrandQueryHandler getBrandQueryHandler, 
            GetBrandByIdQueryHandler getBrandByIdQueryHandler, CreateBrandCommandHandler
            createBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler,
            RemoveBrandCommandHandler removeBrandCommandHandler)
        {
            _getBrandQueryHandler = getBrandQueryHandler;
            _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
            _createBrandCommandHandler = createBrandCommandHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
            _removeBrandCommandHandler = removeBrandCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> Brandlist()
        {
            var values = await _getBrandQueryHandler.Handle();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrand(int id)
        {
            var value =await _getBrandByIdQueryHandler.Handle(new GetBrandByIdQueryRequest(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommandRequest createBrandCommandRequest)
        {
            await _createBrandCommandHandler.Handle(createBrandCommandRequest);
            return Ok("Marka Bilgisi Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommandRequest updateBrandCommandRequest)
        {
            await _updateBrandCommandHandler.Handle(updateBrandCommandRequest);
            return Ok("Marka Bilgisi Güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBrand(int id)
        {
            await _removeBrandCommandHandler.Handle(new RemoveBrandCommandRequest(id));
            return Ok("Marka Bilgisi Silindi.");
        }
    }

}

