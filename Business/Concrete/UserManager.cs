using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(SuccessMessages.UserAdded);
        }

        public IResult Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IList<User>> GetAll()
        {
            var result = _userDal.GetAll();
            if (result == null) return new ErrorDataResult<IList<User>>(ErrorMessages.ErrorUsersListed);
            return new SuccessDataResult<IList<User>>(result, SuccessMessages.UsersListed);
        }

        public IDataResult<User> GetByEmail(string mail)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Email == mail));
        }

        public IDataResult<User> GetByUserCode(int userCode)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.UserCode == userCode));
        }

        public IResult Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
