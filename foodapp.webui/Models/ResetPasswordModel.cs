using System.ComponentModel.DataAnnotations;

namespace foodapp.webui.Models
{
    public class ResetPasswordModel
    {
        [Required]
        public string Token { get; set; }
        [Required(ErrorMessage="Şifre girilmelidir.")]
        [Display(Name="Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage="Şifre girilmelidir.")]
        [Display(Name="Yeni Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
    }
}