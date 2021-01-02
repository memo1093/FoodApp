using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace foodapp.webui.Models
{
    public class UserDetailModel
    {
        public string UserId { get; set; }
        [Display(Name="Kullanıcı Adı")]
        public string UserName { get; set; }
        [Display(Name="Adı")]
        public string FirstName { get; set; }
        [Display(Name="Soyadı")]
        public string LastName { get; set; }
        [Display(Name="Email")]
        public string Email { get; set; }
        [Display(Name="Email Onayı")]
        public bool EmailConfirmed { get; set; }
        public IEnumerable<string> SelectedRoles { get; set; }
    }
}