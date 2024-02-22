using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Blog.UpdateBlog
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Domain.Entities.Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            var value =await  _repository.GetByIdAsync(request.BlogID);
            value.AuthorID = request.AuthorID;
            value.CategoryID= request.CategoryID;
            value.Title= request.Title;
            value.CoverImageUrl = request.CoverImageUrl;
            value.CreatedDate = request.CreatedDate;
            value.Description= request.Description;
            await _repository.UpdateAsync(value);

        }
    }
}
