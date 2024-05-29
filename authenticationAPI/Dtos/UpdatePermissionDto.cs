using System.ComponentModel.DataAnnotations;

namespace authenticationAPI.Dtos
{
    public class UpdatePermissionDto
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

    }
}
