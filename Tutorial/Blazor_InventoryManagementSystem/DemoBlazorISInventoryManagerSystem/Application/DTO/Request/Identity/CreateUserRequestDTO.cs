using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request.Identity
{
    public class CreateUserRequestDTO : LoginUserRequestDTO
    {
        [Required]
        public required string Name { get; set; }
        [Required]
        [Compare(nameof(Password))]
        public required string ConfirmPassword { get; set; }
        [Required]
        public required string Policy { get; set; }
    }
}
