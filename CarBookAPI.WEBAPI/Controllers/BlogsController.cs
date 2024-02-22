using CarBookAPI.Application.Features.Mediator.Commands.Blog.CreateBlog;
using CarBookAPI.Application.Features.Mediator.Commands.Blog.RemoveBlog;
using CarBookAPI.Application.Features.Mediator.Commands.Blog.UpdateBlog;
using CarBookAPI.Application.Features.Mediator.Queries.Blog.GetBlog;
using CarBookAPI.Application.Features.Mediator.Queries.Blog.GetBlogById;
using CarBookAPI.Application.Features.Mediator.Queries.Blog.GetLast3BlogsWithAuthors;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            List<GetBlogQueryResponse> getBlogQueryResponses = await _mediator.Send(new GetBlogQueryRequest());
            return Ok(getBlogQueryResponses);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(int id)
        {
            GetBlogByIdQueryResponse getBlogByIdQueryResponse = await _mediator.Send(new GetBlogByIdQueryRequest(id));
            return Ok(getBlogByIdQueryResponse);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommandRequest createBlogCommandRequest)
        {
            await _mediator.Send(createBlogCommandRequest);
            return Ok("Blog Bilgisi Eklendi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommandRequest updateBlogCommandRequest)
        {
            await _mediator.Send(updateBlogCommandRequest);
            return Ok("Blog Bilgisi Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommandRequest(id));
            return Ok("Blog Bilgisi Silindi");
        }

        [HttpGet("GetLast3BlogsWithAuthorsList")]
        public async Task<IActionResult> GetLast3BlogsWithAuthorsList()
        {
            var values = await _mediator.Send(new GetLast3BlogsWithAuthorsQueryRequest());
            return Ok(values);
        }
    }
}
