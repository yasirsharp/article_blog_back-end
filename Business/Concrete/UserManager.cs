using Business.Abstract;
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
            return new SuccessResult("Kullanıcı eklendi.");
        }

        public IResult Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IList<User>> GetAll()
        {
            var result = _userDal.GetAll();
            if (result == null) return new ErrorDataResult<IList<User>>("Kullanıcılar listelenemedi!");
            return new SuccessDataResult<IList<User>>(result, "Kullanıcılar listelendi.");
        }

        public IDataResult<User> GetByEmail(string mail)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
