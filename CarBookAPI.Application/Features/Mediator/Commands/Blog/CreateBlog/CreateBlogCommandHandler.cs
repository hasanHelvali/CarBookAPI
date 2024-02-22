using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Blog.CreateBlog
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Blog> _blogRepository;

        public CreateBlogCommandHandler(IRepository<Domain.Entities.Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task Handle(CreateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            await _blogRepository.CreateAsync(new Domain.Entities.Blog
            {
                AuthorID = request.AuthorID,
                CategoryID= request.CategoryID,
                Description = request.Description,
                Title = request.Title,
                CoverImageUrl = request.CoverImageUrl,
                CreatedDate = request.CreatedDate,
            });
        }
    }
}
