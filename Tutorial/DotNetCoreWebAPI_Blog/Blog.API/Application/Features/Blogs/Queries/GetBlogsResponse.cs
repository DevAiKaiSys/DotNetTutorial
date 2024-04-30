using Application.Responses;

namespace Application.Features.Blogs.Queries
{
    public class GetBlogsResponse : BaseResponse
    {
        public List<BlogDto>? Blogs { get; set; }
    }
}
