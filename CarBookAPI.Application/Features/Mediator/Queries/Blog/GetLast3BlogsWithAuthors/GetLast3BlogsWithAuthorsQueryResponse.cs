namespace CarBookAPI.Application.Features.Mediator.Queries.Blog.GetLast3BlogsWithAuthors
{
    public class GetLast3BlogsWithAuthorsQueryResponse
    {
        public int BlogID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public string? AuthorName { get; set; }
    }
}