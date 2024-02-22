namespace CarBookAPI.Application.Features.Mediator.Queries.Author.GetAuthorById
{
    public class GetAuthorByIdQueryResponse
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}