using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService _userService;

        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }
        
        public IResult PasswordReset(UserForPasswordResetDto userForPasswordResetDto)
        {
            byte[] passwordHash, passwordSalt;
            User userToCheck = _userService.GetByHvBSNumber(userForPasswordResetDto.HvBSNumber).Data;
            if (userToCheck == null)
            {
                return new ErrorResult(Messages.HvBsNumberError);
            }
            HashingHelper.CreatePasswordHash(userForPasswordResetDto.HvBSNumber, out passwordHash, out passwordSalt);
            userToCheck.PasswordHash = passwordHash;
            userToCheck.PasswordSalt = passwordSalt;
            _userService.Update(userToCheck);
            return new SuccessResult(Messages.PasswordReset);
        }

        public IResult Login(UserForLoginDto userForLoginDto)
        {
            User userToCheck = _userService.GetByHvBSNumber(userForLoginDto.HvBSNumber).Data;
            if (userToCheck == null)
            {
                return new ErrorResult(Messages.HvBsNumberError);
            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorResult(Messages.PasswordError);
            }
            return new SuccessResult(Messages.LoginSuccessful);
        }

        public IResult ChangePassword(UserForPasswordChangeDto userForPasswordChangeDto)
        {
            User userToCheck = _userService.GetByHvBSNumber(userForPasswordChangeDto.HvBSNumber).Data;
            byte[] passwordHash, passwordSalt;
            if (userToCheck == null)
                return new ErrorResult(Messages.HvBsNumberError);
            if (!HashingHelper.VerifyPasswordHash(userForPasswordChangeDto.OldPassword, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorResult(Messages.PasswordError);
            }
            if (userForPasswordChangeDto.OldPassword == userForPasswordChangeDto.NewPassword)
            {
                return new ErrorResult(Messages.PasswordSame);
            }
            HashingHelper.CreatePasswordHash(userForPasswordChangeDto.NewPassword, out passwordHash, out passwordSalt);
            userToCheck.PasswordHash = passwordHash;
            userToCheck.PasswordSalt = passwordSalt;
            _userService.Update(userToCheck);
            return new SuccessResult(Messages.PasswordChanged);
        }

        public IResult Register(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            User user = new User
            {
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                HvBSNumber = userForRegisterDto.HvBSNumber,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                PhoneNumber = userForRegisterDto.PhoneNumber,
                Rank = userForRegisterDto.Rank,
                Status = true,
            };
            _userService.Add(user);
            return new SuccessResult(Messages.UserRegistered);
        }
    }
}