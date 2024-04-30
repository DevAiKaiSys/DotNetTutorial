namespace Application.DTO.Response.Identity
{
    public class BaseUserClaimsDTO
    {
        public required string UserId { get; set; }
        public required string Name { get; set; }
        public required string RoleName { get; set; }
        public bool ManageUser { get; set; }
        public bool Read { get; set; }
        public bool Delete { get; set; }
        public bool Updae { get; set; }
        public bool Create { get; set; }
    }
}
