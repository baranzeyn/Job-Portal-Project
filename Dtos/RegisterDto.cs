using System.ComponentModel.DataAnnotations;

namespace Job_Portal_Project.Dtos
{
    public record RegisterDto
    {
        [Required(ErrorMessage ="Username is required.")]
        public String? UserName { get; init; }
        [Required(ErrorMessage ="Email is required.")]
        public String? Email { get; init; }
        [Required(ErrorMessage ="Password is required.")]
        public String? Password { get; init; }  

        public String? Role { get; init; }
    }
}