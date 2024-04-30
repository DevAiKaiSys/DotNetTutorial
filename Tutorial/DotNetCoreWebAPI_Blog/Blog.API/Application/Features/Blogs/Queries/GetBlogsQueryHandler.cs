using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Blogs.Queries
{
    public class GetBlogsQueryHandler : IRequestHandler<GetBlogsQuery, GetBlogsResponse>
    {
        private readonly IRepository<Blog> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetBlogsQueryHandler> _logger;

        public GetBlogsQueryHandler(IRepository<Blog> repository, IMapper mapper, ILogger<GetBlogsQueryHandler> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<GetBlogsResponse> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
        {
            GetBlogsResponse getBlogResponse = new();
            GetBlogsValidator validator = new();

            try
            {
                FluentValidation.Results.ValidationResult validationResult = await validator.ValidateAsync(request, new CancellationToken());
                if (validationResult.Errors.Count > 0)
                {
                    getBlogResponse.Success = false;
                    getBlogResponse.ValidationErrors = [];
                    foreach (string? error in validationResult.Errors.Select(x => x.ErrorMessage))
                    {
                        getBlogResponse.ValidationErrors.Add(error);
                        _logger.LogError($"validation failed due to error- {error} ");
                    }
                }
                else if (getBlogResponse.Success)
                {
                    IReadOnlyList<Blog> result = await _repository.GetAllAsync();
                    getBlogResponse.Blogs = _mapper.Map<List<BlogDto>>(result);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"error while due to error- {ex.Message} ");
                getBlogResponse.Success = false;
                // convert to you own message to show user
                getBlogResponse.Message = ex.Message;
            }
            return getBlogResponse;
        }
    }
}
