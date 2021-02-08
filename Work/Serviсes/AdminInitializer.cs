using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Work.Models;

namespace Work.Serviсes
{
    public class AdminInitializer
    {
         public static async Task SeedAdminUser(
                            RoleManager<IdentityRole> roleManager,
                            UserManager<User> userManager)
                        {
                            string adminEmail = "admin@admin.com";
                            string adminPassword = "Qwerty123@";
                            var roles = new[] { "admin", "economist","manager" };
                            foreach (var role in roles)
                            {
                                if (await roleManager.FindByNameAsync(role) is null)
                                    await roleManager.CreateAsync(new IdentityRole(role));
                            }
        
                            if (await userManager.FindByEmailAsync(adminEmail) is null)
                            {
                       
                                User admin = new User
                                {
                                    Email = adminEmail,
                                  
                                };
                                var result = await userManager.CreateAsync(admin, adminPassword);
                                if (result.Succeeded)
                                    await userManager.AddToRoleAsync(admin, "admin");
                            }
                        }
    }
}