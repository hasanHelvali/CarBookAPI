using CarBookAPI.Application.Features.GenericRepository;
using CarBookAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commentsRepository;

        public CommentsController(IGenericRepository<Comment> commentsRepository)
        {
            _commentsRepository = commentsRepository;
        }
        [HttpGet]
        public IActionResult CommentList()
        {
            var values= _commentsRepository.GetAll();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetCommandById(int id)
        {
            var value = _commentsRepository.GetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCommand(Comment comment)
        {
            _commentsRepository.Create(comment);
            return Ok("Yorum Başarıyla Eklenmiştir.");
        }
        [HttpPut]
        public IActionResult UpdateCommand(Comment comment)
        {
            _commentsRepository.Update(comment);
            return Ok("Yorum Başarıyla Güncellenmiştir.");
        }
        [HttpDelete]
        public IActionResult RemoveCommand(int id)
        {
           var value= _commentsRepository.GetById(id);
            _commentsRepository.Remove(value);
            return Ok("Yorumunuz Başarıyla Silinmiştir.");
        }
    }
}
