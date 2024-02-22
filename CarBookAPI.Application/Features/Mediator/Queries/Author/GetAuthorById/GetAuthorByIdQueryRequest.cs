using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Author.GetAuthorById
{
    public class GetAuthorByIdQueryRequest:IRequest<GetAuthorByIdQueryResponse>
    {
        public int ID { get; set; }

        public GetAuthorByIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}