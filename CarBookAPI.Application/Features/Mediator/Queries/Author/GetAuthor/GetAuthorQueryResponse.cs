namespace CarBookAPI.Application.Features.Mediator.Queries.Author.GetAuthor
{
    public class GetAuthorQueryResponse
    {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public string Description { get; set; }
    }
}