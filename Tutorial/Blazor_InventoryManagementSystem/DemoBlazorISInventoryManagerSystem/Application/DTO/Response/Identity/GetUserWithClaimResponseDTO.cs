namespace Application.DTO.Response.Identity
{
    public class GetUserWithClaimResponseDTO : BaseUserClaimsDTO
    {
        public required string Email { get; set; }
    }
}
