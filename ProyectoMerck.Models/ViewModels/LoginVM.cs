using ProyectoMerck.Resources;
using System.ComponentModel.DataAnnotations;

namespace ProyectoMerck.Models.ViewModels
{
    public class LoginVM
    {
        [EmailAddress(ErrorMessageResourceType = typeof(ValidationResources), ErrorMessageResourceName = "Email")]
        [Required(ErrorMessageResourceType = typeof(ValidationResources), ErrorMessageResourceName = "Required")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(ValidationResources), ErrorMessageResourceName = "Required")]
        public string Password { get; set; }    

        public string CurrentCulture { get; set; }

    }
}
