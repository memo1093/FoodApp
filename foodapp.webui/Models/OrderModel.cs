using System.ComponentModel.DataAnnotations;

namespace foodapp.webui.Models
{
    public class OrderModel
    {
        public CartModel CartModel { get; set; }


        [Display(Name = "Alıcının Adı", Prompt = "Ad")]
        [Required(ErrorMessage = "Alıcının adı alanı boş bırakılamaz.")]
        public string FirstName { get; set; }


        [Display(Name = "Alıcının Soyadı", Prompt = "Soyad")]
        [Required(ErrorMessage = "Alıcının soyadı alanı boş bırakılamaz.")]
        public string LastName { get; set; }


        [Display(Name = "Alıcının Adresi", Prompt = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1 Kadıköy/İstanbul")]
        [Required(ErrorMessage = "Alıcının adres alanı boş bırakılamaz.")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }


        [Display(Name = "Şehir")]
        [Required(ErrorMessage = "Şehir seçilmelidir.")]
        public string City { get; set; }


        [Display(Name = "Posta Kodu", Prompt = "34732")]
        [Required(ErrorMessage = "Posta kodu mutlaka girilmelidir.")]
        public string ZipCode { get; set; }

        [Display(Name = "Email", Prompt = "email_123@gmail.com")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email adresi girilmelidir")]
        public string Email { get; set; }


        [Display(Name = "Alıcının Telefonu", Prompt = "5551231212")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Alıcının telefon numarası mutlaka girilmelidir.")]
        public string Phone { get; set; }



        [Display(Name = "Kart Sahibinin Adı Soyadı", Prompt = "Ad Soyad")]
        [Required(ErrorMessage = "Kart Sahibinin Adı boş geçilemez.")]
        public string CardName { get; set; }


        [Display(Name = "Kart Numarası", Prompt = "1234567891011121")]
        [DataType(DataType.CreditCard)]
        [Required(ErrorMessage = "Kart Numarası boş geçilemez.")]
        public string CardNumber { get; set; }


        [Display(Name = "Kartın Son Kullanma tarihi(Ay)", Prompt = "12")]
        [MaxLength(2)]
        [Required(ErrorMessage = "Kartın Son Kullanma tarihi girilmelidir.")]
        public string ExpirationMonth { get; set; }


        [Display(Name = "Kartın Son Kullanma tarihi(Yıl)", Prompt = "2030")]
        [MaxLength(4)]
        [Required(ErrorMessage = "Kartın Son Kullanma tarihi girilmelidir.")]
        public string ExpirationYear { get; set; }


        [Display(Name = "CVC", Prompt = "123")]
        [MaxLength(3)]
        [Required(ErrorMessage = "Kartın Cvc bilgisi girilmelidir.")]
        public string Cvc { get; set; }


    }
}