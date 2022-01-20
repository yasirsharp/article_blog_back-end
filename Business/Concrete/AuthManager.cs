using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        IUserService _userService;

        public AuthManager(IUserService userService)
        {
            _userService = userService;
        }

        public IDataResult<User> Login(UserForLogin userForLogin)
        {
            var userToCheck = _userService.GetByEmail(userForLogin.Email);
            if (userToCheck.Data == null) return new ErrorDataResult<User>(ErrorMessages.UserNotFound);

            if (!HashingHelper.VerifyPasswordHash(userForLogin.Password, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
                return new ErrorDataResult<User>(ErrorMessages.PasswordError);
            return new SuccessDataResult<User>(userToCheck.Data, SuccessMessages.LoginSuccess);
        }

        public IDataResult<User> Register(UserForRegister userForRegister, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            var user = new User
            {
                AccountStatus = true,
                Email = userForRegister.Email,
                UserName = userForRegister.UserName,
                UserCode = userForRegister.UserCode,
                UserFirstName = userForRegister.UserFirstName,
                UserLastName = userForRegister.UserLastName,
                PasswordSalt = passwordSalt,
                PasswordHash = passwordHash,
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, SuccessMessages.RegisterSuccessful);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByEmail(email).Data != null)
            {
                return new ErrorResult(ErrorMessages.UserAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
