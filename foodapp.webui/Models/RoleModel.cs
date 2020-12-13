using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using foodapp.webui.Identity;
using Microsoft.AspNetCore.Identity;

namespace foodapp.webui.Models
{
    public class RoleModel
    {
        [Required(ErrorMessage="Rol adı girilmelidir.")]
        [Display(Name="Rol Adı")]
        public string Name { get; set; }
    }

    public class RoleDetails
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<User> Members { get; set; }
        public IEnumerable<User> NonMembers { get; set; }
    }
    public class RoleEditModel
    {
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}