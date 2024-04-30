using FluentValidation;

namespace Application.Features.Blogs.Queries
{
    public class GetBlogsValidator : AbstractValidator<GetBlogsQuery>
    {
        public GetBlogsValidator()
        {
            //
            //RuleFor(p => 1)
            //    .GreaterThan(0)
            //    .WithMessage("{PropertyName} should have greater than value");
        }
    }
}
