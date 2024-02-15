namespace CarBookAPI.Application.Features.Mediator.Queries.Service.GetService
{
    public class GetServiceQueryResponse
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}