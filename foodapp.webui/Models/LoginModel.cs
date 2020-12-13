using System.ComponentModel.DataAnnotations;

namespace foodapp.webui.Models
{
    public class LoginModel
    {
        [Display(Name="Kullanıcı Adı")]
        [Required(ErrorMessage="Kullanıcı adı girmelisiniz.")]
        
        public string UserName { get; set; }

        [Display(Name="Şifre")]
        [Required(ErrorMessage="Şifre kısmı boş bırakılamaz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}