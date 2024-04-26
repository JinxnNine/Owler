using Owler.Models;

namespace Owler.Services;

public interface IUserServices
{


    //Task<bool> Login(UserLoginModel userLoginModel);
    Task<bool> Register(UserRegisterModel userRegisterModel);
}