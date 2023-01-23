using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IResult Register(UserForRegisterDto userForRegisterDto);
        IResult Login(UserForLoginDto userForLoginDto);
        IResult ChangePassword(UserForPasswordChangeDto userForPasswordChange);
        IResult PasswordReset(UserForPasswordResetDto userForPasswordResetDto);
    }
}