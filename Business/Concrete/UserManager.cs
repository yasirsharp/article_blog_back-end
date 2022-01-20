using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Dto;
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

        public IDataResult<List<User>> GetAll()
        {
            var result = _userDal.GetAll();
            if (result == null) return new ErrorDataResult<List<User>>(ErrorMessages.ErrorUsersListed);
            return new SuccessDataResult<List<User>>(result, SuccessMessages.UsersListed);
        }

        public IDataResult<List<ArticleOfUser>> GetArticles(User user)
        {
            var result = _userDal.GetArticles(user);
            return new SuccessDataResult<List<ArticleOfUser>>(result, SuccessMessages.GetArticlesOfUser);
        }

        public IDataResult<User> GetByEmail(string mail)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Email == mail));
        }

        public IDataResult<User> GetByUserCode(int userCode)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.UserCode == userCode));
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user), SuccessMessages.ClaimsListed);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(SuccessMessages.UserUpdated);
        }
    }
}
