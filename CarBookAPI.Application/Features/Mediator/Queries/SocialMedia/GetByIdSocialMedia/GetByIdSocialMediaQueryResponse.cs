namespace CarBookAPI.Application.Features.Mediator.Queries.SocialMedia.GetByIdSocialMedia
{
    public class GetByIdSocialMediaQueryResponse
    {
        public int SocialMediaID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}