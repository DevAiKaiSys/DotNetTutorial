namespace Application.Features
{
    public class BlogDto : BaseDto
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
    }
}
