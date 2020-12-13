using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace foodapp.webui.Identity
{
    public static class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,IConfiguration configuration)
        {
            var username = configuration["Data:AdminUser:username"];
            var password = configuration["Data:AdminUser:password"];
            var email = configuration["Data:AdminUser:email"];
            var role1 = configuration["Data:AdminUser:role1"];
            var role2 = configuration["Data:AdminUser:role2"];
            var role3 = configuration["Data:AdminUser:role3"];

            if (await userManager.FindByNameAsync(username)==null)
            {
                
                await roleManager.CreateAsync(new IdentityRole(role1));
                await roleManager.CreateAsync(new IdentityRole(role2));
                await roleManager.CreateAsync(new IdentityRole(role3));

                var user = new User(){
                    UserName=username,
                    Email=email,
                    FirstName="Admin",
                    LastName="Admin",
                    EmailConfirmed=true,

                };
                string[] adminroles = new string[]{role1,role2};
                var result = await userManager.CreateAsync(user,password);
                if (result.Succeeded)
                {
                    await userManager.AddToRolesAsync(user,adminroles);
                }

                
                
            }
        }
    }
}