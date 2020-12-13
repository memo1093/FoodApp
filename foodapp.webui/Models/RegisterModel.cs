using System.ComponentModel.DataAnnotations;

namespace foodapp.webui.Models
{
    public class RegisterModel
    {
        [Display(Name="Ad")]
        [Required(ErrorMessage="Ad kısmı boş bırakılamaz.")]
        public string FirstName { get; set; }

        [Display(Name="Soyad")]
        [Required(ErrorMessage="Soyad kısmı boş bırakılamaz.")]
        public string LastName { get; set; }

        
        [Display(Name="Kullanıcı Adı")]
        [Required(ErrorMessage="Kullanıcı adı girmelisiniz.")]
        public string UserName { get; set; }

        [Display(Name="Şifre")]
        [Required(ErrorMessage="Şifre kısmı boş bırakılamaz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name="Şifre Tekrar")]
        [Required(ErrorMessage="Şifre tekrarı girilmelidir.")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage="Şifrelerin eşleşmesi gerekmektedir.")]
        public string RePassword { get; set; }

        [Display(Name="Email")]
        [Required(ErrorMessage="Email kısmı boş bırakılamaz.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}