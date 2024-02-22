﻿using CarBookAPI.Domain.Entities;
using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Blog.UpdateBlog
{
    public class UpdateBlogCommandRequest:IRequest
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
    }
}