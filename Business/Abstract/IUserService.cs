using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);

        IDataResult<IList<User>> GetAll();
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<List<ArticleOfUser>> GetArticles(User user);
        IDataResult<User> GetByUserCode(int userCode);
        IDataResult<User> GetByEmail(string mail);
    }
}
