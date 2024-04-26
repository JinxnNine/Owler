using Microsoft.AspNetCore.Identity;
using Owler.Data;
using Owler.Models;

namespace Owler.Services;

public class UserServices : IUserServices
{

    SignInManager<User> SignInManager { get; set; }
    UserManager<User> UserManager { get; set; }
    RoleManager<IdentityRole> RoleManager { get; set; }
    ApplicationDbContext ApplicationDbContext { get; set; }
    public UserServices(SignInManager<User> signInManager, UserManager<User> userManager, ApplicationDbContext applicationDbContext, RoleManager<IdentityRole> roleManager)
    {
        SignInManager = signInManager;
        UserManager = userManager;
        ApplicationDbContext = applicationDbContext;
        RoleManager = roleManager;
    }
 

    public async Task<bool> Register(UserRegisterModel userRegisterModel)
    {

        if (await UserManager.FindByEmailAsync(userRegisterModel.Email) is not null)
        {
            return false;
        }
        if (await RoleManager.FindByNameAsync(userRegisterModel.UserType.ToString()) == null)
        {
            await RoleManager.CreateAsync(new IdentityRole(userRegisterModel.UserType.ToString()));
        }

        var user = new User()
        {
            Name = userRegisterModel.Email.Split('@')[0],
            UserName = userRegisterModel.Email.Split('@')[0],
            Email = userRegisterModel.Email,
            Type = userRegisterModel.UserType
        };
        try
        {

            await ApplicationDbContext.Users.AddAsync(user);
            await ApplicationDbContext.SaveChangesAsync();

            await UserManager.UpdateNormalizedEmailAsync(user);
            await UserManager.UpdateNormalizedUserNameAsync(user);
            await UserManager.AddPasswordAsync(user, userRegisterModel.Password);
            var result = await UserManager.AddToRoleAsync(user, userRegisterModel.UserType.ToString());

            await ApplicationDbContext.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            await Console.Out.WriteLineAsync(ex.Message);
            return false;
        }

        return true;

    }
}