using CarBookAPI.Application.Features.CQRS.Commands.Category.CreateCategory;
using CarBookAPI.Application.Features.CQRS.Commands.Category.RemoveCategory;
using CarBookAPI.Application.Features.CQRS.Commands.Category.UpdateCategory;
using CarBookAPI.Application.Features.CQRS.Queries.Category.GetCategory;
using CarBookAPI.Application.Features.CQRS.Queries.Category.GetCategoryById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCategoryCommandHandler;
        private readonly RemoveCategoryCommandHandler _removeCategoryCommandHandler;

        public CategoriesController(GetCategoryQueryHandler getCategoryQueryHandler,
            GetCategoryByIdQueryHandler getCategoryByIdQueryHandler,

            CreateCategoryCommandHandler createCategoryCommandHandler,
            UpdateCategoryCommandHandler updateCategoryCommandHandler,
            RemoveCategoryCommandHandler removeCategoryCommandHandler)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _updateCategoryCommandHandler = updateCategoryCommandHandler;
            _removeCategoryCommandHandler = removeCategoryCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> Categorylist()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value =await _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQueryRequest(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommandRequest createCategoryCommandRequest)
        {
            await _createCategoryCommandHandler.Handle(createCategoryCommandRequest);
            return Ok("Kategori Bilgisi Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommandRequest updateCategoryCommandRequest)
        {
            await _updateCategoryCommandHandler.Handle(updateCategoryCommandRequest);
            return Ok("Kategori Bilgisi Güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCategory(int id)
        {
            await _removeCategoryCommandHandler.Handle(new RemoveCategoryCommandRequest(id));
            return Ok("Kategori Bilgisi Silindi.");
        }
    }
}
