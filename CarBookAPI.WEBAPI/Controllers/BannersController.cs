using CarBookAPI.Application.Features.CQRS.Commands.Banner.CreateBanner;
using CarBookAPI.Application.Features.CQRS.Commands.Banner.RemoveBanner;
using CarBookAPI.Application.Features.CQRS.Commands.Banner.UpdateBanner;
using CarBookAPI.Application.Features.CQRS.Queries.Banner.GetBanner;
using CarBookAPI.Application.Features.CQRS.Queries.Banner.GetBannerById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly GetBannerQueryHandler _getBannerQueryHandler;
        private readonly GetBannerByIdQueryHandler _getBannerByIdQueryHandler;
        private readonly CreateBannerCommandHandler _createBannerCommandHandler;
        private readonly UpdateBannerCommandHandler _updateBannerCommandHandler;
        private readonly RemoveBannerCommandHandler _removeBannerCommandHandler;

        public BannersController(GetBannerQueryHandler getBannerQueryHandler, 
            GetBannerByIdQueryHandler getBannerByIdQueryHandler, 
            CreateBannerCommandHandler createBannerCommandHandler, 
            UpdateBannerCommandHandler updateBannerCommandHandler,
            RemoveBannerCommandHandler removeBannerCommandHandler)
        {
            _getBannerQueryHandler = getBannerQueryHandler;
            _getBannerByIdQueryHandler = getBannerByIdQueryHandler;
            _createBannerCommandHandler = createBannerCommandHandler;
            _updateBannerCommandHandler = updateBannerCommandHandler;
            _removeBannerCommandHandler = removeBannerCommandHandler;
        }


        [HttpGet]
        public async Task<IActionResult> BannerList()
        {
            var values = await _getBannerQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBanner(int id)
        {
            var value = await _getBannerByIdQueryHandler.Handle(new GetBannerByIdQueryRequest(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommandRequest createBannerCommandRequest)
        {
            await _createBannerCommandHandler.Handle(createBannerCommandRequest);
            return Ok("Bilgi Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerCommandRequest updateBannerCommandRequest)
        {
            await _updateBannerCommandHandler.Handle(updateBannerCommandRequest);
            return Ok("Bilgi Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBanner(int id)
        {
            await _removeBannerCommandHandler.Handle(new RemoveBannerCommandRequest(id));
            return Ok("Bilgi Silindi");
        }

    }

}
